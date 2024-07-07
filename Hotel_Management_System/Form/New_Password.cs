using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{

    public partial class New_Password : Form
    {
        function fn = new function();
        String query;
        public String username;
        public String email;
        public New_Password()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text.Trim()==String.Empty || txtConfirmPass.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill all the field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(txtNewPass.Text == txtConfirmPass.Text)
                {
                    query = "update employee set pass ='"+txtConfirmPass.Text+ "' where username ='"+username+"'and emailid = '"+email+"'";
                    fn.setData(query, "Password Changed Successfully..");
                    //MessageBox.Show("Password Changed Successfully..","", MessageBoxButtons.OK);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Mismatched", "New Password != Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
