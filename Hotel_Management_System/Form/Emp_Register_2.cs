using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Management_System
{
    public partial class Emp_Register_2 : Form
    {

        function fn = new function();
        String query;

        public String name, gender, emailid;
        public Int64 mobile;

        public Emp_Register_2()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim()==string.Empty || txtPass.Text.Trim() == string.Empty || txtRePass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all the field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string userName = txtUsername.Text;
                string pass = txtPass.Text;
                string rePass = txtRePass.Text;

                if (pass == rePass)
                {
                    try
                    {
                        query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('" + name + "'," + mobile + ",'" + gender + "','" + emailid + "','" + userName + "','" + pass + "')";
                        fn.setData(query, "Employee Registered Successful..");

                        this.Close();
                        Login lg = new Login();
                        lg.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("With this Email Employee already Present", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Password Mismatched", "Set Password != Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
