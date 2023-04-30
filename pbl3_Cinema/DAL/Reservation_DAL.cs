using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyFuncStatic;

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

        public List<HistoryInforTicket> GetListBookingByIdCustomer(string id_customer)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                List<HistoryInforTicket> historyInforTickets = new List<HistoryInforTicket>();
                var l = db.reservations.Where(p => p.customer_id == id_customer)
                    .Join(db.screenings,
                    r => r.screening_id,
                    s => s.id,
                    (r,s) => new { r, s }).
                    Join(db.movies,
                    rs => rs.s.movie_id,
                    m => m.id,
                    (rs, m) => new {rs, m.title, m.poster}).
                    Join(db.auditoriums,
                    rsm => rsm.rs.s.auditorium_id,
                    a => a.id,
                    (rsm, a) => new {rsm, a.name_auditorium}).OrderByDescending(sort => sort.rsm.rs.r.booking_date);
                foreach (var item in l)
                {
                    historyInforTickets.Add(new HistoryInforTicket
                    {
                        id = item.rsm.rs.r.id,
                        id_auditorium = item.rsm.rs.s.auditorium_id,
                        name_auditorium = item.name_auditorium,
                        id_movie = item.rsm.rs.s.movie_id,
                        title = item.rsm.title,
                        image = MyConvert.ConvertBinaryToImage(item.rsm.poster),

                        bookingDay = item.rsm.rs.r.booking_date,

                        id_screening = item.rsm.rs.s.id,
                        showDay = item.rsm.rs.s.show_day,
                        showTime = item.rsm.rs.s.show_time
                    });
                }
                return historyInforTickets;
            }
        }

        public HistoryInforTicket GetBookingByIdReservation(int id_reservation)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                List<HistoryInforTicket> historyInforTickets = new List<HistoryInforTicket>();
                var item = db.reservations.Where(p => p.id == id_reservation)
                    .Join(db.screenings,
                    r => r.screening_id,
                    s => s.id,
                    (r, s) => new { r, s }).
                    Join(db.movies,
                    rs => rs.s.movie_id,
                    m => m.id,
                    (rs, m) => new { rs, m.title, m.poster }).
                    Join(db.auditoriums,
                    rsm => rsm.rs.s.auditorium_id,
                    a => a.id,
                    (rsm, a) => new { rsm, a.name_auditorium }).FirstOrDefault();
                return new HistoryInforTicket
                {
                    id = item.rsm.rs.r.id,
                    id_auditorium = item.rsm.rs.s.auditorium_id,
                    name_auditorium = item.name_auditorium,
                    id_movie = item.rsm.rs.s.movie_id,
                    title = item.rsm.title,
                    image = MyConvert.ConvertBinaryToImage(item.rsm.poster),

                    bookingDay = item.rsm.rs.r.booking_date,

                    id_screening = item.rsm.rs.s.id,
                    showDay = item.rsm.rs.s.show_day,
                    showTime = item.rsm.rs.s.show_time
                };
            }
        }
    }
}
