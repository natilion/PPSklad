using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPSklad
{
    public partial class SkladAdd : Form
    {
        int SelectedItemID;
        int ID;
        int RID;
        SqlConnection con = Links.con;
        SqlCommand cmd;

        public SkladAdd(int id, int SIID)
        {
            InitializeComponent();
            ID = id;
            SelectedItemID = SIID;
        }

        private void Role()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("select Role from dbo.[User] where ID_User = '{0}'", ID);
            RID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
        }

        private void SkladAdd_Load(object sender, EventArgs e)
        {
            if (SelectedItemID == 0)
                bAdd.Text = "Добавить";
            else
            {
                bAdd.Text = "Обновить";
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = String.Format("select Name_Item, Specification_Item, About_Item, User_ID from dbo.[Item] where ID_Item = '{0}'", SelectedItemID);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    name.Text = reader.GetValue(0).ToString();
                    specs.Text = reader.GetValue(1).ToString();
                    about.Text = reader.GetValue(2).ToString();
                    cmd.CommandText = String.Format("select Name_User, Last_Name_User from dbo.[User] where ID_User = '{0}'", reader.GetValue(3).ToString());
                }
                reader.Close();
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    WhoEdit.Text = String.Format("Последнее изменение от: {0} {1}", reader1.GetValue(1).ToString(), reader1.GetValue(0).ToString());
                }
                reader1.Close();
                con.Close();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (name.Text != "" & specs.Text != "" & about.Text != "")
            {
                if (SelectedItemID == 0)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = String.Format("insert into [dbo].[Item] ([Name_Item],[Specification_Item],[About_Item],[User_ID])" +
                                                    " values('{0}', '{1}', '{2}', {3})", name.Text, specs.Text, about.Text, ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Предмет добавлен");
                    SkladAdd.ActiveForm.Hide();
                    Sklad sklad = new Sklad(ID);
                    sklad.Show();
                }
                else
                {
                    con.Open();
                    cmd.CommandText = String.Format("update [dbo].[Item] set [Name_Item]='{1}',[Specification_Item]='{2}',[About_Item]='{3}',[User_ID]='{4}' where ID_Item='{0}'",
                                                    SelectedItemID, name.Text, specs.Text, about.Text, ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные обновлены");
                    con.Close();
                    SkladAdd.ActiveForm.Hide();
                    Sklad sklad = new Sklad(ID);
                    sklad.Show();
                }
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            SkladAdd.ActiveForm.Hide();
            Sklad sklad = new Sklad(ID);
            sklad.Show();
        }
    }
}