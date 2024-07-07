using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Management_System
{
    public partial class Emp_Register_1 : Form
    {

        public Emp_Register_1()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim()==String.Empty || txtMobileNo.Text.Trim() == String.Empty || cmbGender.Text.Trim() == String.Empty || txtEmailid.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill all the field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Emp_Register_2 emp2 = new Emp_Register_2();
                emp2.name = txtName.Text;
                emp2.mobile = Int64.Parse(txtMobileNo.Text);
                emp2.gender = cmbGender.Text;
                emp2.emailid = txtEmailid.Text;

                emp2.Show();
                this.Close();
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9 || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
