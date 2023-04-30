using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.ManageBooking
{
    public partial class Form_ManageBooking : Form
    {
        public string Account { set; get; }
        public Form_ManageBooking()
        {
            InitializeComponent();
        }

        private void Form_ManageBooking_Load(object sender, EventArgs e)
        {
            Reservation_BLL bll = new Reservation_BLL();
            var list = bll.GetListBookingByIdCustomer(this.Account);
            foreach ( var item in list )
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
            Form_InforBooking form = new Form_InforBooking()
            {
                id_screening = h.id_screening
            };
            form.ShowDialog();
        }
    }
}
