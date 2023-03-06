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
    public partial class Form2 : Form
    {
        private List<Button> rooms;
        private RoomRezervation rezervation;
        Button room = null;

       
       

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Button> rooms, RoomRezervation rezervation):this()
        {
            //form1 dekı oda butonlarını burda kullanmak için 
            this.rooms = rooms;
           //ve kayıtlı musterılerı gorebılmek.
            this.rezervation = rezervation;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            LoadRoom();
        }

        private void LoadRoom()
        {
            //form 1 den form 2 ye gecerken odalrı tasıyor.
            for (int i = 0; i < 10; i++)
            {
                //burda sadece clıck eventlerını dınledık.
               rooms[i].Click += Form2_Click;
               // katlara odaları ekledık.
                floor1.Controls.Add(rooms[i]);

            }
            for (int i = 10; i < 20; i++)
            {
                rooms[i].Click += Form2_Click;
                floor2.Controls.Add(rooms[i]);

            }
            for (int i = 20; i < 30; i++)
            {
                rooms[i].Click += Form2_Click;
                floor3.Controls.Add(rooms[i]);

            }
            //Son odamız kral dairesi oldugu için -1
            rooms[rooms.Count - 1].Click += Form2_Click;
            kingFloor.Controls.Add(rooms[rooms.Count - 1]);
        }
        // kayıt olan musterileri tuttugumuz rezervasyon ve 
        //butonu tıkladıgımız zaaman butondakı rezervasyon musterı bılgısını versın.
        RoomRezervation updatedRezervation = null;
        private void Form2_Click(object sender, EventArgs e)
        {
         //hangı odaya tıkladıysa o oadnın dolu mu bos mu oldugunu dolu ıse
         // kımın kladıgını ve nekadar kaldıgını gostermek.
            room = sender as Button;
           

            UpdateRoom();
        }
        public void UpdateRoom()
        {
          //musterı rezervasyonu uzatmakk ısterse
            updatedRezervation = room.Tag as RoomRezervation;
            //dıalog result ıle mesaj gosterdık
            DialogResult dialog = MessageBox.Show("Kayıdı uzatmak istiyor musunuz ?", "Kayıt", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                //kayıt uzatma formu
                grpUpdate.Visible = true; // gorunus
                lblnameSurname.Text = updatedRezervation.Customer.NameSurname;
                lbidentity.Text = updatedRezervation.Customer.IdentityNumber;
                lblphone.Text = updatedRezervation.Customer.PhoneNumber;
                lblbirth.Text = updatedRezervation.Customer.Birthday;

            }
            else
            {
                //Çıkış yapma formu 

                Form3 frm = new Form3(updatedRezervation);
               frm.Show();

            }
        }

        public void UpdateButton()
        {
            if (updatedRezervation.Customer.Date.ExitDate.Date == dateExit.Value.Date)//uzatacgı tarıh 
            {
                MessageBox.Show("Tarihi Güncellemediniz");
            }
            else
            {
                MessageBox.Show("Eski Çıkıs Tarihiniz:" + updatedRezervation.Customer.Date.ExitDate.Date.ToString());
                updatedRezervation.Customer.Date.ExitDate = dateExit.Value.Date;
                MessageBox.Show("Yeni Çıkıs Tarihiniz:" + dateExit.Value.Date);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateButton();
        }

       
    }
    }

