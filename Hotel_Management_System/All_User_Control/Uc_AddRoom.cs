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
    public partial class Uc_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public Uc_AddRoom()
        {
            InitializeComponent();
        }

        private void Uc_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.GetData(query);
            dataGVAddRoom.DataSource = ds.Tables[0];
        }

        private void btAddRoom_Click_1(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && cmbRoomtype.Text != "" && cmbBed.Text != "" && txtRoomNo.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String roomtype = cmbRoomtype.Text;
                String bed = cmbBed.Text;
                Int64 price = Int64.Parse(txtRoomNo.Text);

                try
                {
                    query = "insert into rooms (roomNo,roomType,bed,price) values ('" + roomno + "','" + roomtype + "','" + bed + "','" + price + "')";
                    fn.setData(query, "Room Added.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Room is Already Added Please try different room no","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                Uc_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearAll()
        {
            txtRoomNo.Clear();
            cmbRoomtype.SelectedIndex = -1;
            cmbRoomtype.Text = null;
            cmbBed.Text = null;
            cmbBed.SelectedIndex = -1;
            txtRoomNo.Clear();

        }
        private void Uc_AddRoom_Leave(object sender, EventArgs e)
        {
            Uc_AddRoom_Load(this, null);
            clearAll();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9 || e.KeyChar == (char)Keys.Back)
            {

            }
            else
                e.Handled = true;
        }

        private void txtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9 || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void Uc_AddRoom_Enter(object sender, EventArgs e)
        {
            Uc_AddRoom_Load(this, null);
        }

        private void txtPrice_KeyPress_1(object sender, KeyPressEventArgs e)
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
