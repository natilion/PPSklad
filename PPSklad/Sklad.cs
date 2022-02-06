using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPSklad
{
    public partial class Sklad : Form
    {
        int ID = 0;
        int SelectedItemID = 0;
        public Sklad(int id)
        {
            InitializeComponent();
            ID = id;
        }

        SqlConnection con = Links.con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList(string a)
        {
            da = new SqlDataAdapter(a, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sklad");
            dataGridView1.DataSource = ds.Tables["Sklad"];
            con.Close();
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            GetList("select * from dbo.[Item]");
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Sklad.ActiveForm.Hide();
            SkladAdd skladAdd = new SkladAdd(ID, 0);
            skladAdd.Show();
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            if (SelectedItemID != 0)
            {
                Sklad.ActiveForm.Hide();
                SkladAdd skladAdd = new SkladAdd(ID, SelectedItemID);
                skladAdd.Show();
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить этот предмет ?", "Удаление предмета", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = String.Format("delete from Item where ID_Item ='{0}'", cell.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList("select * from dbo.[Item]");
                }
                MessageBox.Show("Данные удалены");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            SelectedItemID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_Item"].Value);
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            Sklad.ActiveForm.Hide();
            Auto auto = new Auto();
            auto.Show();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            GetList(String.Format("select [ID_Item], [Name_Item], [Specification_Item], [About_Item], [User_ID] from dbo.[Item] " +
                "where[ID_Item] LIKE '%{0}%' or [Name_Item] LIKE '%{0}%' or [Specification_Item] LIKE '%{0}%' or [About_Item] LIKE '%{0}%' " +
                " or [User_ID] LIKE '%{0}%'", name.Text));
        }
    }
}