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
    public partial class Uc_CustomerDetails : UserControl
    {
        function fn = new function();
        String query;
        public Uc_CustomerDetails()
        {
            InitializeComponent();
        }

        private void cmbSearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSearchby.SelectedIndex == 0)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.idproof,customer.address,customer.reserve_date,customer.checkin,customer.checkoutdate,customer.cancel,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price,customer.registeredby from customer inner join rooms on customer.roomId=rooms.roomId";
                getRecord(query);
            }
            else if(cmbSearchby.SelectedIndex == 1)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.idproof,customer.address,customer.reserve_date,customer.checkin,customer.checkoutdate,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price,customer.registeredby from customer inner join rooms on customer.roomId=rooms.roomId where cancel='NO'and checkoutdate is null";
                getRecord(query);
            }
            else if (cmbSearchby.SelectedIndex == 2)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.idproof,customer.address,customer.reserve_date,customer.checkin,customer.checkoutdate,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price,customer.registeredby from customer inner join rooms on customer.roomId=rooms.roomId where checkoutdate is not null";
                getRecord(query);
            }
            else if (cmbSearchby.SelectedIndex == 3)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.idproof,customer.address,customer.reserve_date,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price,customer.registeredby from customer inner join rooms on customer.roomId=rooms.roomId where cancel='YES'";
                getRecord(query);
            }
        }
        private void getRecord(String query)
        {
            DataSet ds = fn.GetData(query);
            dataGVCustomerDetails.DataSource = ds.Tables[0];
        }
    }
}
