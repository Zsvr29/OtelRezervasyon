using Otel.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution.OtelDüzeltmeUI
{
    public partial class Form4 : Form
    {
        private RoomRezervation updatedRezervation;
        private double finalPrice;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(RoomRezervation updatedRezervation,double finalPrice):this()
        {
            this.updatedRezervation = updatedRezervation;
            this.finalPrice = finalPrice;
        }

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            Report();
        }

        private void Report()
        {
            int totalDay = Convert.ToInt32(updatedRezervation.Customer.Date.ExitDate.Date.Day) - Convert.ToInt32(updatedRezervation.Customer.Date.ComingDate.Day);
            int price = (Convert.ToInt32(updatedRezervation.Room.RoomPrice));
           lblnameSurname.Text = updatedRezervation.Customer.NameSurname;
            lblıdentity.Text = updatedRezervation.Customer.IdentityNumber;
            lblphone.Text =updatedRezervation.Customer.PhoneNumber;
            lblbirthday.Text = updatedRezervation.Customer.Birthday;
            lbldatecoming.Text = updatedRezervation.Customer.Date.ComingDate.ToString();
            lbldateExit.Text = updatedRezervation.Customer.Date.ExitDate.ToString();
            lbltotalDay.Text = totalDay.ToString();
            lbltotalPrice.Text = finalPrice.ToString();
            
            

        }
    }
}
