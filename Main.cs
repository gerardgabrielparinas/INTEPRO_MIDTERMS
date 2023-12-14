using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contacts.BusinessLogic;

namespace Parinas___INTEPRO_MidtermMP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private ContactsBLL con = new ContactsBLL();
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvContacts.DataSource = con.GetAll();
        }
        private void Resetcontrols()
        {
            txtID.Clear(); txtName.Clear(); txtNo.Clear();
            btnView_Click(new object(), new EventArgs());
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Resetcontrols();
        }
        //Makes it so that specified txtbox only detects numerical keystrokes
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //Makes it so that specified txtbox only detects numerical keystrokes
        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {   
                con.ID = int.Parse(txtID.Text);
                con.Name = txtName.Text;
                con.ContactNo = txtNo.Text;
                con.Validate();
                con.Add();

                MessageBox.Show("Record added successfully.");
                Resetcontrols();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                ErrorText.Visible = true;
            }
        }

        private int conID = 0;

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvContacts.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvContacts.SelectedRows[0].Cells[1].Value.ToString();
            txtNo.Text = dgvContacts.SelectedRows[0].Cells[2].Value.ToString();
            conID = (int)dgvContacts.SelectedRows[0].Cells[0].Value;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            con.ID = conID;
            con.Delete();

            MessageBox.Show("Record deleted successfully");
            Resetcontrols();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con.ID = int.Parse(txtID.Text);
                con.Name = txtName.Text;
                con.ContactNo = txtNo.Text;
                con.Edit(conID);
                con.Validate();

                MessageBox.Show("Record edited successfully.");
                Resetcontrols();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        private void btnTerminate_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
