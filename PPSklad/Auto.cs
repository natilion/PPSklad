using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPSklad
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }

        SqlConnection con = Links.con;
        SqlCommand cmd;
        int uid;

        private void bLog_Click(object sender, EventArgs e)
        {
            string Password = "";
            int id;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            try
            {
                cmd.CommandText = String.Format("select Login from [dbo].[User] where Login = '{0}'", login.Text);
                if (cmd.ExecuteScalar() != null)
                {
                    cmd.CommandText = String.Format("select Password from [dbo].[User] where Login = '{0}'", login.Text);
                    Password = cmd.ExecuteScalar().ToString();
                    if (Password != password.Text)
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                    else
                    {
                        cmd.CommandText = String.Format("select Role from [dbo].[User] where Login = '{0}'", login.Text);
                        id = Convert.ToInt32(cmd.ExecuteScalar());
                        cmd.CommandText = String.Format("select ID_User from [dbo].[User] where Login = '{0}' AND Password = '{1}'", login.Text, password.Text);
                        uid = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                        switch (id)
                        {
                            case 0:
                                Auto.ActiveForm.Hide();
                                Admin admin = new Admin();
                                admin.Show();
                                break;
                            case 1:
                                Auto.ActiveForm.Hide();
                                Sklad sklad = new Sklad(uid);
                                sklad.Show();
                                break;
                        }
                    }
                    MessageBox.Show("Успешная авторизация");
                }
                else
                    MessageBox.Show("Неверный логин");
            }
            finally { con.Close(); }
        }
    }
}