using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;

namespace pbl3_Cinema.BLL
{
    internal class Reservation_BLL
    {
        public int AddReservationCustomer(List<seat_reserved> seats, List<detail_bill> detail_Bills, reservation _reservation, int discount_point)
        {
            int sumPrice = 0;
            foreach (detail_bill item in detail_Bills)
            {
                sumPrice += item.the_number_of_products * item.price;
            }

            bill b = new bill()
            {
                reservation_id = _reservation.id,
                booking_day = DateTime.Now,
                sum_price = sumPrice,
            };
            
            Reservation_DAL dal = new Reservation_DAL();
            return dal.AddReservationCustomer(seats, detail_Bills,b ,_reservation, discount_point);
        }

        public int AddReservationStaff(List<seat_reserved> listSeat,List<detail_bill> detail_Bills, reservation _reservation)
        {
            int sumPrice = 0;
            foreach (detail_bill item in detail_Bills)
            {
                sumPrice += item.the_number_of_products * item.price;
            }

            bill b = new bill()
            {
                reservation_id = _reservation.id,
                booking_day = DateTime.Now,
                sum_price = sumPrice,
            };

            Reservation_DAL dal = new Reservation_DAL();
            return dal.AddReservationStaff(listSeat, detail_Bills, b, _reservation);
        }

        public reservation GetReservationById(int reservation_id)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetReservationById(reservation_id);
        }

        public List<HistoryInforTicket> GetListBookingByIdCustomer(string id_customer)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetListBookingByIdCustomer(id_customer);
        }

        public List<HistoryInforTicket> GetListBookingByIdStaff(string id_staff)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetListBookingByIdStaff(id_staff);
        }

        public List<HistoryInforTicket> GetListBookingByIdScreening(int id_screening)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetListBookingByIdScreening(id_screening);
        }

        public HistoryInforTicket GetBookingByIdReservation(int id_reservation)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetBookingByIdReservation(id_reservation);
        }

        public List<seat_reserved> GetReservedSeatByIdReservation(int id_reservation)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetReservedSeatByIdReservation(id_reservation);
        }

        public List<detail_bill> GetListDetailBillByIdBill(int id_bill)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetListDetailBillByIdBill(id_bill);
        }

        public List<detail_bill> GetListDetailBillByIdReservation(int id_reservation)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetListDetailBillByIdBill(dal.GetIdBillByIdReservation(id_reservation));
        }

        internal void UpdateReservation(int id_reservation, bool paid)
        {
            Reservation_DAL dal = new Reservation_DAL();
            dal.UpdateReservation(id_reservation, paid);
        }

        internal void UpdateReservation(int id_reservation,int tempSum,int discount_point, int discount_pay ,bool paid)
        {
            Reservation_DAL dal = new Reservation_DAL();
            dal.UpdateReservation(id_reservation,tempSum,discount_point, discount_pay, paid);
        }

        public void CancelReservation(int id_reservation)
        {
            Reservation_DAL dal = new Reservation_DAL();
            dal.CancelReservation(id_reservation);
        }
    }
}
