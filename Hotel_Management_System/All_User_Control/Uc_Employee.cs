using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.All_User_Control
{
    public partial class Uc_Employee : UserControl
    {
        function fn = new function();
        String query;
        public Uc_Employee()
        {
            InitializeComponent();
        }

        private void Uc_Employee_Load(object sender, EventArgs e)
        {
            getMaxId();
            query = "select * from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                Login lg = new Login();
                lg.Show();
            }
        }

        private void getMaxId()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                if (num >= 0)
                {
                    lblRedid.Text = (num + 1).ToString();
                }
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtMobileNo.Text != "" && cmbGender.Text != "" && txtEmailid.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobileNo.Text);
                string gender = cmbGender.Text;
                string emailid = txtEmailid.Text;
                string userName = txtUserName.Text;
                string password = txtPassword.Text;

                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('"+name+"',"+mobile+",'"+gender+"','"+emailid+"','"+userName+"','"+password+"')";
                fn.setData(query, "Employee Registered.");

                clearAll();
                getMaxId();
            }
            else
            {
                MessageBox.Show("Please fill all the field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearAll()
        {
            txtName.Clear();
            txtMobileNo.Clear();
            cmbGender.SelectedIndex = -1;
            txtEmailid.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void EmpRegi_Leave(object sender, EventArgs e)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                Login lg = new Login();
                lg.Show();
            }
            clearAll();
        }

        private void Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Employee.SelectedIndex == 1)
            {
                setEmployee(dataGVEmpDetails);
            }
            else if (Employee.SelectedIndex == 2)
            {
                setEmployee(dataGVDeleted);
            }
        }

        private void setEmployee(Guna2DataGridView dataGVEmpDetails)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);
            dataGVEmpDetails.DataSource = ds.Tables[0];
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Are you Sure", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = "+txtID.Text+"";
                    fn.setData(query, "Record Deleted.");
                    Employee_SelectedIndexChanged(this, null);
                }
            }
            query = "select * from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                Login lg = new Login();
                lg.Show();
            }           
        }

        private void Uc_Employee_Leave(object sender, EventArgs e)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                Login lg = new Login();
                lg.Show();
            }
            clearAll();
        }

        private void dataGVDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVDeleted.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtID.Text = dataGVDeleted.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
