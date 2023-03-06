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
    public partial class Form3 : Form
    {
        private RoomRezervation updatedRezervation;
       double price;
        int totalDay;
        double finalPrice;

        public Form3()
        {
            InitializeComponent();
           
          
        }

        public Form3(RoomRezervation updatedRezervation):this()
        {
            this.updatedRezervation = updatedRezervation;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Information();
        }
           public void Information()
        {
            
            totalDay = Convert.ToInt32(updatedRezervation.Customer.Date.ExitDate.Date.Day) - Convert.ToInt32(updatedRezervation.Customer.Date.ComingDate.Date.Day);
            price = (Convert.ToDouble(updatedRezervation.Room.RoomPrice));
            finalPrice = totalDay * price;
            lbltotalDay.Text = (totalDay.ToString());
            lbltotalPrice.Text = finalPrice.ToString();

    
           
        }     

        public void Extras()
        {
            foreach (Control item  in groupBoxExtras.Controls )
            {
                if (item is CheckBox)
                {
                    CheckBox minibar = item as CheckBox;
                    if (minibar.Checked == true)
                    {
                        finalPrice += 10;
                        item.Enabled = false;
                    }
                }
              
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Form4 frm= new Form4 (updatedRezervation,finalPrice);
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Extras();
            lbltotalPrice.Text = finalPrice.ToString();
            


        }
    }
}
