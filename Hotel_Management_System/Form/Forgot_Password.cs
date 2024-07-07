using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Forgot_Password : Form
    {
        function fn = new function();
        String query;
        
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {   
            if (txtUsername.Text.Trim() == string.Empty || txtEmailid.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please fill all the field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                query = "select * from employee where username = '" + txtUsername.Text + "'and emailid ='" + txtEmailid.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("User Found Successful..","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    New_Password nps = new New_Password();
                    nps.username = txtUsername.Text;
                    nps.email = txtEmailid.Text;
                    nps.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No Record Found with this Username and Email","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
