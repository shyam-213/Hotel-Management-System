using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel_Management_System.User_Control
{
    public partial class Uc_CostomerCheckInOut : UserControl
    {
        function fn = new function();
        String query;
        public Uc_CostomerCheckInOut()
        {
            InitializeComponent();
        }

        private void Uc_CostomerCheckOut_Load(object sender, EventArgs e)
        {
            cmbDateTime.MinDate = DateTime.Now;
            cmbDateTime.MaxDate = cmbDateTime.Value.AddMonths(3);
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.idproof,customer.address,customer.reserve_date,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId where checkout = 'NO' and cancel ='NO'";
            DataSet ds = fn.GetData(query);
            dataGV_Checkout.DataSource = ds.Tables[0];
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.idproof,customer.address,customer.reserve_date,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId where cname like '" + txtName.Text+"%'and checkout = 'NO'";
            DataSet ds = fn.GetData(query);
            dataGV_Checkout.DataSource = ds.Tables[0];
        }
        int id;

        private void dataGV_Checkout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_Checkout.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGV_Checkout.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = dataGV_Checkout.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomno.Text = dataGV_Checkout.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }
        
        public void clearAll()
        {
            txtName.Clear();
            txtCName.Clear();
            txtRoomno.Clear();
            cmbDateTime.ResetText();
        }

        private void Uc_CostomerCheckOut_Leave(object sender, EventArgs e)
        {
            Uc_CostomerCheckOut_Load(this, null);
            clearAll();
        }


        private void btCheckin_Click(object sender, EventArgs e)        // this code is for check in where employee can update customer chei status
        {
            if (txtCName.Text != "" && txtRoomno.Text != "")
            {
                query = "select * from customer where cid = '" + id + "'and checkin ='NULL'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    String cdate = cmbDateTime.Text;
                    query = "update customer set checkin ='" + cdate + "'where cid = " + id + "";
                    fn.setData(query, "Check In Successfully.");
                }
                else
                {
                    MessageBox.Show("Customer already Checked In", "informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                Uc_CostomerCheckOut_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "" && txtRoomno.Text != "")
            {
                if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    query = "select * from customer where cid = '" + id + "'and checkin is not null";
                    DataSet ds = fn.GetData(query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        String cdate = cmbDateTime.Text;
                        query = "update rooms set booked ='NO' where roomNo='" + txtRoomno.Text + "'update customer set checkout ='YES',checkoutdate='" + cdate + "' where cid = " + id + "and checkin is not null";
                        fn.setData(query, "Check Out Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Checked In", "informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Uc_CostomerCheckOut_Load(this, null);
                    clearAll();
                }

            }
            else
            {
                MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "" && txtRoomno.Text != "")
            {
                query = "select * from customer where cid = '" + id + "'and checkin ='NULL'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    query = "update rooms set booked = 'NO' where roomNo = '" + txtRoomno.Text + "'update customer set cancel ='YES' where cid = " + id + "";
                    fn.setData(query, "Room Cancellation Successfully.");
                }
                else
                {
                    MessageBox.Show("Customer already Checked In", "informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Uc_CostomerCheckOut_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
