using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DAL
{
    internal class Reservation_DAL
    {
        public void AddReservationCustomer(List<seat_reserved> seats, List<detail_bill> detail_Bills,bill b, reservation _reservation, int discount_point)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                db.reservations.Add(_reservation);
                db.SaveChanges();

                foreach(seat_reserved seat in seats)
                {
                    seat.reservation_id = _reservation.id;
                    db.seat_reserved.Add(seat);
                    db.SaveChanges();
                }

                b.reservation_id = _reservation.id;
                db.bills.Add(b);
                db.SaveChanges();

                foreach(detail_bill item in detail_Bills)
                {
                    item.bill_id = b.id;
                    var p = db.products.Find(item.product_id);
                    p.the_number_of_products -= item.the_number_of_products;

                    db.detail_bill.Add(item);
                    db.SaveChanges();
                }

                var cus = db.customers.Find(_reservation.customer_id);
                cus.discount_points -= discount_point;
                cus.discount_points += _reservation.sum_pay / 2000;
                db.SaveChanges();
            }
        }
    }
}
