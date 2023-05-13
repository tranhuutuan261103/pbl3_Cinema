using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.ManageBooking
{
    public partial class Form_InforBooking : Form
    {
        public int id_reservation { set; get; }
        public int id_screening { set; get; }
        public Form_InforBooking()
        {
            InitializeComponent();
        }

        private void LoadInforScreening()
        {
            MyUserControlInforTicket uc = new MyUserControlInforTicket()
            {
                id_screening = id_screening,
            };
            panel_InforTicket.Controls.Add(uc);
            uc.Show();
        }
        private void LoadInforReservationSeat()
        {
            Screening_BLL screening_BLL = new Screening_BLL();
            Reservation_BLL bll = new Reservation_BLL();
            List<seat_reserved> list = bll.GetReservedSeatByIdReservation(id_reservation);
            Cinema_BLL bllCinema = new Cinema_BLL();

            string lSeat = list.Count + "x ";
            Seat_BLL seat_BLL = new Seat_BLL();
            foreach (seat seat in seat_BLL.GetAllReservedSeatLocation(list))
            {
                lSeat += (char)(seat.row_location + 64) + (seat.column_location).ToString() + " ";
            }
            ScreeningInfor screenInfor = screening_BLL.GetScreeningInforById(id_screening);
            MyUserControlDetailInforBooking ucdib = new MyUserControlDetailInforBooking()
            {
                nameProduct = lSeat,
                price = screenInfor.price * list.Count,
            };

            flowLayoutPanel.Controls.Add(ucdib);
            ucdib.Show();
        }

        private void LoadInforProduct()
        {
            Product_BLL bllProduct = new Product_BLL();
            Reservation_BLL bllReservation = new Reservation_BLL();
            List<detail_bill> listProduct = bllReservation.GetListDetailBillByIdReservation(id_reservation);
            foreach (detail_bill d in listProduct)
            {
                MyUserControlDetailInforBooking ucdib2 = new MyUserControlDetailInforBooking()
                {
                    nameProduct = d.the_number_of_products + "x " + bllProduct.GetProductName(d.product_id),
                    price = d.price * d.the_number_of_products,
                };
                flowLayoutPanel.Controls.Add(ucdib2);
                ucdib2.Show();
            }
        }

        private void LoadInforDiscount()
        {
            Reservation_BLL bll = new Reservation_BLL();
            reservation r = bll.GetReservationById(id_reservation);
            MyUserControlDetailInforBooking uc = new MyUserControlDetailInforBooking()
            {
                nameProduct = "Giảm",
                price = r.discount_pay,
            };
            flowLayoutPanel.Controls.Add(uc);
            uc.Show();
        }

        private void LoadSumPay()
        {
            Reservation_BLL bll = new Reservation_BLL();
            reservation r = bll.GetReservationById(id_reservation);
            MyUserControlDetailInforBooking uc = new MyUserControlDetailInforBooking()
            {
                nameProduct = "Tổng",
                price = r.sum_pay,
            };
            flowLayoutPanel.Controls.Add(uc);
            uc.Show();
        }
        private void LoadInit()
        {
            LoadInforScreening();
            LoadInforReservationSeat();
            LoadInforProduct();
            LoadInforDiscount();
            LoadSumPay();
        }
        private void Form_InforBooking_Load(object sender, EventArgs e)
        {
            LoadInit();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
