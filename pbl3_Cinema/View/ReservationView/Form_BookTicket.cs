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
using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;

namespace pbl3_Cinema.View.ReservationView
{
    public partial class Form_BookTicket : Form
    {
        private int id_reservation;
        public string Account { set; get; }
        public int id_screening { set; get; }
        public List<seat_reserved> listSeat { set; get; }
        public List<detail_bill> listProduct {set; get; }
        private int tempSum = 0;
        // lưu điểm tạm thời để quy đổi
        private int discountPoint = 0;
        // tỷ lệ điểm quy đổi
        private int ratePoint = 300;
        private MyUserControlDetailInforBooking UCCheck_DiscountPoint;
        public Form_BookTicket(string Account, int id_screen ,List<seat_reserved> listS, List<detail_bill> listProductS)
        {
            InitializeComponent();
            this.Account = Account;
            listSeat = listS;
            listProduct = listProductS;
            id_screening = id_screen;
            LoadInit();
        }



        private void LoadInforScreening()
        {
            MyUserControlInforTicket uc = new MyUserControlInforTicket()
            {
                id_screening = this.id_screening,
            };
            panel_InforTicket.Controls.Add(uc);
            uc.Show();
        }

        private void LoadInforBooking()
        {
            tempSum = 0;
            // danh sách ghế
            Cinema_BLL bll = new Cinema_BLL();
            Screening_BLL screening_BLL = new Screening_BLL();
            Seat_BLL seat_BLL = new Seat_BLL();
            string lSeat = listSeat.Count + "x ";
            foreach(seat seat in seat_BLL.GetAllReservedSeatLocation(listSeat))
            {
                lSeat += (char)(seat.row_location + 64) + (seat.column_location).ToString() + " ";
            }
            ScreeningInfor screenInfor = screening_BLL.GetScreeningInforById(id_screening);
            MyUserControlDetailInforBooking ucdib = new MyUserControlDetailInforBooking()
            {
                nameProduct = lSeat,
                price = screenInfor.price * listSeat.Count,
            };
            tempSum += ucdib.price;

            flowLayoutPanel.Controls.Add(ucdib);
            ucdib.Show();


            // danh sách sản phẩm
            Product_BLL bllProduct = new Product_BLL();
            foreach(detail_bill d in listProduct)
            {
                MyUserControlDetailInforBooking ucdib2 = new MyUserControlDetailInforBooking()
                {
                    nameProduct = d.the_number_of_products + "x " + bllProduct.GetProductName(d.product_id),
                    price = d.price * d.the_number_of_products,
                };
                flowLayoutPanel.Controls.Add(ucdib2); 
                ucdib2.Show();
                tempSum += ucdib2.price;
            }

            // tạm tính 
            MyUserControlDetailInforBooking UCTempSum = new MyUserControlDetailInforBooking
            {
                nameProduct = "Tạm tính",
                price = tempSum
            };
            flowLayoutPanel.Controls.Add(UCTempSum);
            UCTempSum.Show();

            // điểm chiết khấu
            flowLayoutPanel.Controls.Add(UCCheck_DiscountPoint);
            UCCheck_DiscountPoint.Show();
        }

        private void LoadInforPoint()
        {
            groupBox_Discount.Visible = true;
            Account_BLL bll = new Account_BLL();
            if (bll.GetRole(Account) == 0)
            {
                int point = bll.GetDiscountPoint(Account);
                label_Point.Text = point.ToString();
                if (point*ratePoint < tempSum)
                {
                    checkBox_Point.Text = "Dùng " + point + " điểm";
                    discountPoint = point;
                }
                else if (point*ratePoint >= tempSum)
                {
                    checkBox_Point.Text = "Dùng " + Math.Ceiling( (double)(tempSum / ratePoint)) + "điểm";
                    discountPoint = (int)Math.Ceiling((double)(tempSum / ratePoint));
                }
                
            }
        }
        public void LoadInit()
        {
            LoadInforScreening();
            UCCheck_DiscountPoint = new MyUserControlDetailInforBooking
            {
                nameProduct = "Giảm giá",
                price = 0
            };
            LoadInforBooking();

            Account_BLL bll = new Account_BLL();
            if (bll.GetRole(Account) == (int)Role.Customer)
            {
                LoadInforPoint();
            }
            else if (bll.GetRole(Account) == (int)Role.Staff)
            {

            }
            id_reservation = MakeReservation();

            // Thêm sự kiện cho nút bấm
            btn_Booking.Click += new EventHandler(btn_Booking_Click);
            btn_Exit.Click += new EventHandler(btn_Exit_Click);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            CancelReservation();
            Dispose();
        }

        public delegate void CloseForm();
        public CloseForm cf { set; get; }

        private int MakeReservation()
        {
            int discount_pay = UCCheck_DiscountPoint.price;
            reservation r = new reservation()
            {
                screening_id = id_screening,
                booking_date = DateTime.Now,
                pay = tempSum,
                discount_pay = discount_pay,
                sum_pay = tempSum - discount_pay,
            };

            Account_BLL bllAccount = new Account_BLL();
            Reservation_BLL bll = new Reservation_BLL();
            if (bllAccount.GetRole(Account) == (int)Role.Customer )
            {
                r.customer_id = Account;
                if (checkBox_Point.Checked)
                {
                    return bll.AddReservationCustomer(listSeat, listProduct, r, discountPoint);
                }
                else
                {
                    return bll.AddReservationCustomer(listSeat, listProduct, r, 0);
                }
                
            }
            else if (bllAccount.GetRole(Account) == (int)Role.Staff )
            {
                r.staff_id = Account;
                return bll.AddReservationStaff(listSeat, listProduct, r);
                
            }
            return 0;
        }

        private void AcceptReservation()
        {
            Account_BLL bll = new Account_BLL();
            Reservation_BLL bllReservation = new Reservation_BLL();
            if (bll.GetRole(Account) == (int)Role.Customer)
            {
                if (checkBox_Point.Checked)
                {
                    bllReservation.UpdateReservation(id_reservation, tempSum, discountPoint, UCCheck_DiscountPoint.price, true);
                }
                else
                {
                    bllReservation.UpdateReservation(id_reservation, true);
                }
                bll.UpdateDiscountPoint(id_reservation, tempSum -  UCCheck_DiscountPoint.price);
            }
            else if (bll.GetRole(Account) == (int)Role.Staff)
            {
                bllReservation.UpdateReservation(id_reservation, true);
            }
        }

        public void CancelReservation()
        {
            Reservation_BLL bll = new Reservation_BLL();
            bll.CancelReservation(id_reservation);
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {

            int discount_pay = UCCheck_DiscountPoint.price;
            if (MessageBox.Show("Xác nhận thanh toán " + (tempSum - discount_pay), "Thanh toán", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AcceptReservation();

                SendInforToEmail();
                MessageBox.Show("Đã đặt thành công");
                
                Visible = false;
                cf();
                Dispose();
            }
        }

        private void checkBox_Point_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Point.Checked)
            {
                if (discountPoint * ratePoint > tempSum)
                {
                    UCCheck_DiscountPoint.price = tempSum;
                }
                else
                {
                    UCCheck_DiscountPoint.price = discountPoint * ratePoint;
                }
                
            }
            else
            {
                UCCheck_DiscountPoint.price = 0;
            }
        }

        private void SendInforToEmail()
        {
            Account_BLL bll =new Account_BLL();
            if (bll.GetRole(Account) == (int)Role.Customer)
            {
                MyFuncStatic.MyEmailFunc.SendInforBookingToEmail(Account, id_reservation);
            }
        }

        private enum Role
        {
            Customer = 0,
            Staff = 1
        }
    }
}
