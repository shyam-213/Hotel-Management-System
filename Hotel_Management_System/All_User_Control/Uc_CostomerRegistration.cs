using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.User_Control
{
    public partial class Uc_CostomerRegistration : UserControl
    {
        function fn = new function();
        String query;
        public int eid;

        public Uc_CostomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(String query,ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while(sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetInt32(i));
                }
            }
            sdr.Close();
        }

        private void cmbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomtype.SelectedIndex = -1;
            cmbRoomno.Items.Clear();
            txtPrice.Clear();
        }
        private void cmbRoomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomno.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + cmbBed.Text + "'and roomType='" + cmbRoomtype.Text + "'and booked='No'";
            setComboBox(query, cmbRoomno);
        }
        int rid;
        private void cmbRoomno_SelectedIndexChanged(object sender, EventArgs e)
        {
            query="select price,roomId from rooms where roomNo='"+cmbRoomno.Text+"'";
            DataSet ds = fn.GetData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

       

        // Events Validations
        public void ClearAll()
        {
            txtName.Clear();
            txtMobileno.Clear();
            txtNationality.Clear();
            cmbGender.SelectedIndex = -1;
            txt_IDproof.Clear();
            txtAddress.Clear();
            cmbReservation.ResetText();
            cmbBed.SelectedIndex = -1;
            cmbRoomtype.SelectedIndex = -1;
            cmbRoomno.SelectedIndex = -1;
            txtPrice.Clear();
        }
        private void txtMobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9 || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
        private void Uc_CostomerRegistration_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9 || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void Uc_CostomerRegistration_Load(object sender, EventArgs e)
        {
            cmbReservation.MinDate = DateTime.Now;
            cmbReservation.MaxDate = cmbReservation.Value.AddMonths(6);
        }

        private void btReserve_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobileno.Text != "" && txtNationality.Text != "" && cmbGender.Text != "" && txt_IDproof.Text != "" && txtAddress.Text != "" && cmbReservation.Text != "" && txtPrice.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobileno.Text);
                string nationality = txtNationality.Text;
                string gender = cmbGender.Text;
                string idproof = txt_IDproof.Text;
                string addres = txtAddress.Text;
                string reserve = cmbReservation.Text;

                
                try
                {
                    query = "insert into customer (cname,mobile,nationality,gender,idproof,address,reserve_date,registeredby,roomId) values('" + name + "'," + mobile + ",'" + nationality + "','" + gender + "','" + idproof + "','" + addres + "','" + reserve + "','" + eid +"'," + rid + ") update rooms set booked = 'YES' where roomNo = '" + cmbRoomno.Text + "'";
                    fn.setData(query, "Room No " + cmbRoomno.Text + " Resevation Successfull");
                }
                catch (Exception)
                {
                    MessageBox.Show("Id Proof linked with another customer..");
                }
              
                ClearAll();

            }
            else
            {
                MessageBox.Show("All fields are mandatory.", "information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
