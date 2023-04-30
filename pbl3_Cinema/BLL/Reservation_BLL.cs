using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;

namespace pbl3_Cinema.BLL
{
    internal class Reservation_BLL
    {
        public void AddReservationCustomer(List<seat_reserved> seats, List<detail_bill> detail_Bills, reservation _reservation, int discount_point)
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
            dal.AddReservationCustomer(seats, detail_Bills,b ,_reservation, discount_point);
        }

        public List<HistoryInforTicket> GetListBookingByIdCustomer(string id_customer)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetListBookingByIdCustomer(id_customer);
        }

        public HistoryInforTicket GetBookingByIdReservation(int id_reservation)
        {
            Reservation_DAL dal = new Reservation_DAL();
            return dal.GetBookingByIdReservation(id_reservation);
        }
    }
}
