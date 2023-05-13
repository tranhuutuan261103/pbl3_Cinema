using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;
using pbl3_Cinema.View.CustomerView.ManageBooking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.ManageBooking
{
    public partial class Form_ManageReservationDetail : Form
    {
        public delegate void Hiden();
        public Hiden hiden { set; get; }
        public int id_screening { set; get; }
        public Form_ManageReservationDetail()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            hiden();
            Dispose();
        }

        private void Form_ManageReservationDetail_Load(object sender, EventArgs e)
        {
            Form_ManageSeatMap form = new Form_ManageSeatMap();
            form.id_screening = id_screening;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
            //LoadAllReservation();
        }
        /*
        private void LoadAllReservation()
        {
            Reservation_BLL bll = new Reservation_BLL();
            foreach (var item in bll.GetListBookingByIdScreening(id_screening))
            {
                MyUserControlHistoryInforTicket uc = new MyUserControlHistoryInforTicket()
                {
                    id_reservation = item.id,
                    title_movie = item.title,
                    name_auditorium = item.name_auditorium,
                    image = item.image,
                    showDay = item.showDay,
                    showTime = item.showTime,
                    booking_date = item.bookingDay,
                };
                uc.clickEvent += new EventHandler(clicked_UC);
                flowLayoutPanel.Controls.Add(uc);
                uc.Show();
            }
        }

        private void clicked_UC(object sender, EventArgs e)
        {
            MyUserControlHistoryInforTicket uc = (MyUserControlHistoryInforTicket)sender;
            Reservation_BLL bll = new Reservation_BLL();
            HistoryInforTicket h = bll.GetBookingByIdReservation(uc.id_reservation);
            Form_InforBooking_Admin form = new Form_InforBooking_Admin()
            {
                id_screening = h.id_screening,
                id_reservation = h.id
            };
            form.ShowDialog();
        }*/
    }
}
