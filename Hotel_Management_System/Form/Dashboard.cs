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
    public partial class Dashboard : Form
    {
        public string username;
        public string register;
        public int id;

        function fn = new function();
        String query;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void llLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            DialogResult result = MessageBox.Show("Are you want to Log Out ?","Log Out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
                Login loginpage=new Login();
                loginpage.Show();
            }
        }

        private void movePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsername.Text = username;
            register=lblUsername.Text;
            btAddRoom.PerformClick();

            query = "select min(eid) from employee";
            DataSet ds = fn.GetData(query);
            int minId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            if (minId == id)
            {
                btEmployee.Visible = true;
            }
            else
            {
                btEmployee.Visible=false;
            }

        }

        private void btAddRoom_Click(object sender, EventArgs e)
        {
            panelSlide.Visible = true;
            movePanel(btAddRoom);
            uc_AddRoom1.Visible = true;
            uc_AddRoom1.BringToFront();
        }

        private void btClientRegistration_Click(object sender, EventArgs e)
        {
            panelSlide.Visible = true;
            movePanel(btClientRegistration);
            uc_CostomerRegistration1.Visible = true;
            uc_CostomerRegistration1.BringToFront();
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {
            panelSlide.Visible = true;
            movePanel(btCheckout);
            uc_CostomerCheckInOut1.Visible = true;
            uc_CostomerCheckInOut1.BringToFront();

        }

        private void btClientDetails_Click(object sender, EventArgs e)
        {
            panelSlide.Visible = true;
            movePanel(btClientDetails);
            uc_CustomerDetails1.Visible = true;
            uc_CustomerDetails1.BringToFront();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            panelSlide.Visible = true;
            movePanel(btEmployee);
            uc_Employee1.Visible = true;
            uc_Employee1.BringToFront();
        }
    }
}
