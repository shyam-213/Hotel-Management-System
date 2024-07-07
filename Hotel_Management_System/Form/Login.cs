using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using AMRConnector;
using Hotel_Management_System.All_User_Control;
using Hotel_Management_System.User_Control;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        function fn = new function();
        String query;
        public Login()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            picHide.Hide();
            txtPassword.UseSystemPasswordChar = false;
            picShow.Show();
        }

        private void picHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picHide, "Show");
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            picShow.Hide();
            txtPassword.UseSystemPasswordChar = true;
            picHide.Show();
        }

        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picShow, "Hide");
        }

        private void picMinimize_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picMinimize, "Minimize");
        }

        private void picClose_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picClose, "Close");
        }
        public int eid;
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select eid,username,pass from employee where username = '" + txtUsername.Text + "'and pass = '" + txtPassword.Text + "'";
                DataSet ds = fn.GetData(query);

                if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Clear();
                    lblError.Visible = false;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        eid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                        lblError.Visible = false;
                        Dashboard dash = new Dashboard();
                        dash.username = ds.Tables[0].Rows[0][1].ToString();
                        dash.id = eid;

                        Uc_CostomerRegistration cr = new Uc_CostomerRegistration();
                        cr.eid = eid;
                        this.Hide();
                        dash.Show();

                    }
                    else
                    {
                        lblError.Visible = true;
                        txtPassword.Clear();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter Valid Credentials");
            }
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            Emp_Register_1 nr1 = new Emp_Register_1();
            nr1.Show();
            Login_Load(this, null);
        }

        private void lblforgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        
            query = "select * from employee";
            DataSet ds=fn.GetData(query);
    
            if (ds.Tables[0].Rows.Count == 0)
            {
                btLogin.Visible = false;
                btSignup.Visible = true;
            }
            else
            {
                btSignup.Visible=false;
                btLogin.Visible=true;
            }
            
        }
    }
}
