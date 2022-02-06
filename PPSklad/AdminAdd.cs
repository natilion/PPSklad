using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPSklad
{
    public partial class AdminAdd : Form
    {
        int SelectedUserID;
        SqlConnection con = Links.con;
        SqlCommand cmd;
        public AdminAdd(int SUID)
        {
            InitializeComponent();
            SelectedUserID = SUID;
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            if (SelectedUserID == 0)
                bAdd.Text = "Добавить";
            else
            {
                bAdd.Text = "Обновить";
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = String.Format("select Name_User, Last_Name_User, Login, Password, Role from dbo.[User] where ID_User = '{0}'", SelectedUserID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name.Text = reader.GetValue(0).ToString();
                    lastname.Text = reader.GetValue(1).ToString();
                    login.Text = reader.GetValue(2).ToString();
                    pass.Text = reader.GetValue(3).ToString();
                    comboBox1.SelectedIndex = Convert.ToInt32(reader.GetValue(4));
                }
                reader.Close();
                con.Close();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (name.Text != "" & lastname.Text != "" & login.Text != "" & pass.Text != "")
            {
                if (SelectedUserID == 0)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = String.Format("insert into [dbo].[User]([Name_User],[Last_Name_User],[Login],[Password],[Role]) values('{0}', '{1}', '{2}', '{3}', {4})",
                                                        name.Text, lastname.Text, login.Text, pass.Text, comboBox1.SelectedIndex);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Работник добавлен");
                    AdminAdd.ActiveForm.Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }
                else
                {
                    con.Open();
                    cmd.CommandText = String.Format("update [dbo].[User] set [Name_User]='{1}',[Last_Name_User]='{2}',[Login]='{3}',[Password]='{4}',[Role]={5} where ID_User='{0}'",
                                                    SelectedUserID, name.Text, lastname.Text, login.Text, pass.Text, comboBox1.SelectedIndex);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные обновлены");
                    con.Close();
                    AdminAdd.ActiveForm.Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminAdd.ActiveForm.Hide();
            Admin admin = new Admin();
            admin.Show();
        }        
    }
}