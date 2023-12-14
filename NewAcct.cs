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

namespace Parinas___INTEPRO_MidtermMP
{
    public partial class NewAcct : Form
    {
        public NewAcct()
        {
            InitializeComponent();
        }

        private AddAcctBLL acct = new AddAcctBLL();

        private void btnNewAcct_Click(object sender, EventArgs e)
        {
            try
            {
                acct.Username = txtNewUName.Text;
                acct.Password = txtNewPWD.Text;
                acct.ConfirmPWD = txtConfirmPWD.Text;
                acct.Validate1();
                acct.AddAcct();

                MessageBox.Show("Account created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                txtNewUName.Clear();
                txtNewPWD.Clear();
                txtConfirmPWD.Clear();
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login main = new Login();
            main.Show();
            this.Hide();
        }
    }
}
