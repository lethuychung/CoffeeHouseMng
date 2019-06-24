using CoffeeHouse.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeHouse
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String userName = txbUserName.Text;
            String passWord = txbPassWord.Text;

            {
                if (Login(userName, passWord))
                {
                    fTableManager f = new fTableManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("User Name or Password incorrect");
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.OKCancel) !=  System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
    }
}
