using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AddAcct.BusinessLogic;

namespace Parinas___INTEPRO_MidtermMP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string cs = @"Server=VERGIL\MSSQLSERVER2019;" +
            "Database=Parinas_Midterms;Integrated Security=SSPI";
        private AddAcctBLL acct = new AddAcctBLL();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                acct.Username = txtUName.Text;
                acct.Password = txtPWD.Text;
                SqlConnection cn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Login WHERE " +
                    "Username ='" + acct.Username + "'and Password ='" + acct.Password + "'", cn);

                acct.Login();

                SqlDataAdapter SDA = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                SDA.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main MP = new Main();
                    MP.Show();
                }
                else MessageBox.Show("Invalid Username or Password");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAcct_Click(object sender, EventArgs e)
        {
            NewAcct newAcc = new NewAcct();
            newAcc.Show();
            this.Hide();
        }

        private void btnRPWD_Click(object sender, EventArgs e)
        {
            ResetPWD resetPWD = new ResetPWD();
            resetPWD.Show();
            this.Hide();
        }
    }
}
