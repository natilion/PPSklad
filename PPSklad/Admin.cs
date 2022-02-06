using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPSklad
{
    public partial class Admin : Form
    {
        int SelectedUserID = 0;
        public Admin()
        {
            InitializeComponent();
        }

        SqlConnection con = Links.con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            da = new SqlDataAdapter("select * from dbo.[User]", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "User");
            dataGridView1.DataSource = ds.Tables["User"];
            con.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Admin.ActiveForm.Hide();
            AdminAdd adminAdd = new AdminAdd(0);
            adminAdd.Show();
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            if (SelectedUserID != 0)
            {
                Admin.ActiveForm.Hide();
                AdminAdd adminAdd = new AdminAdd(SelectedUserID);
                adminAdd.Show();
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить этот работника ?", "Удаление работника", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = String.Format("delete from dbo.[User] where ID_User ='{0}'", cell.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();
                }
                MessageBox.Show("Данные удалены");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            SelectedUserID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_User"].Value);
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Admin.ActiveForm.Hide();
            Auto auto = new Auto();
            auto.Show();
        }
    }
}