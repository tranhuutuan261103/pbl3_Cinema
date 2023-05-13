using pbl3_Cinema.BLL;
using pbl3_Cinema.DAL;
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
using System.Web.WebSockets;
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

            LoadInfor();
            LoadRevenue();
        }

        private void LoadInfor()
        {
            Screening_BLL bll = new Screening_BLL();
            ScreeningInfor s = bll.GetScreeningInforById(id_screening);
            label_SeatReserved.Text = s.SumSeatReserved + "/" + s.SumSeat;
        }

        private void LoadRevenue()
        {
            Reservation_BLL bll = new Reservation_BLL();
            label_Revenue.Text = bll.GetRevenue(id_screening).ToString();
        }
    }
}
