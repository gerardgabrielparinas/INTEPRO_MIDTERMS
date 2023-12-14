using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddAcct.BusinessLogic;
using Microsoft.Data.SqlClient;

namespace Parinas___INTEPRO_MidtermMP
{
    public partial class ResetPWD : Form
    {
        public ResetPWD()
        {
            InitializeComponent();
        }

        string cs = @"Server=VERGIL\MSSQLSERVER2019;" +
            "Database=Parinas_Midterms;Integrated Security=SSPI";
        private AddAcctBLL acct = new AddAcctBLL();

        private void btnChangePWD_Click(object sender, EventArgs e)
        {
            try
            {
                acct.Username = txtUsername.Text;
                acct.OldPWD = txtOldPWD.Text;
                acct.Password = txtNewPWD.Text;
                SqlConnection cn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Login WHERE " +
                    "Username ='" + acct.Username + "'and Password ='" + acct.OldPWD + "'", cn);

                SqlDataAdapter SDA = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                SDA.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    acct.EditPwd();
                    MessageBox.Show("Password Reset Successful.");
                }
                else MessageBox.Show("Username or Old Password is Invalid");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login main = new Login();
            main.Show();
            this.Hide();
        }
    }
}
