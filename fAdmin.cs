using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CoffeeHouse.DAO;

namespace CoffeeHouse
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadFoodList()
        {
            string query = "SELECT * from food";

            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }


        void LoadAccountList()
        {
            string query = "EXEC USP_GetAccountByUserName @userName";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff1" });

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TpBill_Click(object sender, EventArgs e)
        {

        }
    }
}
