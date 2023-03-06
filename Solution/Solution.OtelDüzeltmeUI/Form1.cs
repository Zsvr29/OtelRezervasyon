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

    public partial class Form1 : Form
    {
       //tıklanılan butona her yerden erısım saglamam lazım kı defaultda null olsunki onunla ılgılı her ıslemı yapabılım.
        // tıklanılan butonun amacı globale almak.
        Button clickedRoom = null;
        List<Button> rooms = new List<Button>();
        RoomRezervation rezervation;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Room_Click(object sender, EventArgs e) //tıkladıgın datayı gonderır.
        {
          //hepsını bır yere baglamak ıcın yeterlı bır tane btn clıck actık.
            clickedRoom = sender as Button; //tıklandıgında buton tıpınde degerını alacam
          //tıklanılan butonun tag degerındekı degerını bana oda rezervasyon olara ver.
            RoomRezervation rezervation = clickedRoom.Tag as RoomRezervation;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateFloorAndRoom();
        }

        public void CreateFloorAndRoom()
        {

           // oda sayılarını 100 den baslattık arttıra arttıra devam ettık.
            int counter = 100;

            for (int i = 0; i < 10; i++) //odaları olusturduk.
            {
           //odaları buton gıbı gosterdık. tum butonların tamamının kontrolunu tek bır alana bagladık.
                Button room = new Button();
                room.Text = (++counter).ToString();
                room.BackColor = Color.Green;
                room.Width = 80;
                room.Height = 30;

                //odanın ozellıklerını tutabılırım. //tag tıpı object
                room.Tag = new RoomRezervation()
                {
                //oda rezervasyon claasımın ıcınde oda ve musterı proportıesı  var
               //oadyı ve musterıyı ordan alırım
               // her bır rezervasyon sonucunda odaya ait musterıyı alabılırız.
                    Room = new Room()
                    {
                        RoomPrice = 50,
                        RoomNumber = int.Parse(room.Text),
                   //defaultta hepsı bos olarak acılacak.Tıklanılan butonun oda durumuna gore de ıslem yaptırabıılırım.
                        RoomSituation = RoomSituation.Empty


                    },

                };
                //btn clık metodunu olusturdu.yanı odalara tıklandıgı zaman
                // event handler oldugu ıcın == degıl += olarak atanır.
                room.Click += Room_Click;
                rooms.Add(room); //dıger fora ulasmak ıcın
                floor1.Controls.Add(room); //odaları buton gıbı gosterdık ve ekledık.
            }
           //tek tek fora almamızın sebebı sayacı kontrol ettık yanı 100den basladı devam ettı
            for (int i = 0; i < 10; i++)
            {
                Button room = new Button();
                room.Text = (++counter).ToString();
                room.BackColor = Color.Green;
                room.Width = 80;
                room.Height = 30;
                room.Tag = new RoomRezervation() //son kullanıcının gormeyecegı tek yer tag onun ıcn orda tuttuk.
                {
                    Room = new Room()
                    {
                        RoomPrice = 100,
                        RoomNumber = int.Parse(room.Text),
                        RoomSituation = RoomSituation.Empty


                    },
                    Customer = new Customer()
                };
                room.Click += Room_Click;
                rooms.Add(room);
                floor2.Controls.Add(room);
            }
            for (int i = 0; i < 10; i++)
            {
                Button room = new Button();
                room.Text = (++counter).ToString();
                room.BackColor = Color.Green;
                room.Width = 80;
                room.Height = 30;
                room.Tag = new RoomRezervation()
                {
                    Room = new Room()
                    {
                        RoomPrice = 150,
                        RoomNumber = int.Parse(room.Text),
                        RoomSituation = RoomSituation.Empty


                    },

                };
                room.Click += Room_Click;
                rooms.Add(room);
                floor3.Controls.Add(room);
            }
            Button kingRoom = new Button();
            kingRoom.Text = "Kral Dairesi";
            kingRoom.BackColor = Color.Green;
            kingRoom.Width = 300;
            kingRoom.Height = 60;
            kingRoom.Tag = new RoomRezervation()
            {
                Room = new Room()
                {
                    RoomNumber = 401,
                    RoomPrice = 1000,
                    RoomSituation = RoomSituation.Empty
                },
            };
            rooms.Add(kingRoom);
            kingRoom.Click += Room_Click;
            kingFloor.Controls.Add(kingRoom);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void AddCustomer()
        {
            if (Validation())
            {
                //tıklanılan buton oda dolu ıse ekleme yapılmamalı.
                rezervation = clickedRoom.Tag as RoomRezervation;
           //odanın bosmu dolumu oldugunu anlarız.burda bosoldugu ıcın rezervasyon aldık.
                if (rezervation.Room.RoomSituation == RoomSituation.Empty) 
                {
                    rezervation.Customer = new Customer() //oda bossa musterı eklıyecem. rezervasyon almak ıcın.
                    {
                        NameSurname = txtnameSurname.Text,
                        Birthday = txtbirth.Text,
                        IdentityNumber= txtıdentity.Text,
                        PhoneNumber = txtphoneNumber.Text,
                        Date = new Date()
                        {
                            ComingDate = datecoming.Value,
                           ExitDate = dateexit.Value

                        }
                    };

                    //ekle bıttıkden sonra  oda  durumunu doluya aldık.
                    rezervation.Room.RoomSituation = RoomSituation.Full; 
                                                                
                    clickedRoom.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
                else
                {
                    MessageBox.Show("Oda şu anda " + rezervation.Room.RoomSituation);
                }


            }

        }


        private bool Validation() //alanların bos gecılemeyecegını kontrol ettık.
        {
            foreach (Control item in customerRezervation.Controls) // tum komponenetler bunun altında 
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Alanlar Boş Bırakılamaz");
                        return false;
                    }
                    else
                    {
                        return true;
                    }


                }
            }
            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 frm= new Form2(rooms,rezervation);
            frm.Show();

        }

        private void customerRezervation_Enter(object sender, EventArgs e)
        {

        }
    }
}
