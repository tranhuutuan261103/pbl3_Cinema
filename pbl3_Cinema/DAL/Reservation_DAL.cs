using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyFuncStatic;

namespace pbl3_Cinema.DAL
{
    internal class Reservation_DAL
    {
        public int AddReservationCustomer(List<seat_reserved> seats, List<detail_bill> detail_Bills,bill b, reservation _reservation, int discount_point)
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
                db.SaveChanges();
                return _reservation.id;
            }
        }

        public int AddReservationStaff(List<seat_reserved> seats,List<detail_bill> detail_Bills,bill b,reservation _reservation)
        {
            int id_reservation = 0;
            using (CinemaEntities db = new CinemaEntities())
            {
                db.reservations.Add(_reservation);
                db.SaveChanges();

                foreach (seat_reserved seat in seats)
                {
                    seat_reserved s = new seat_reserved()
                    {
                        reservation_id = _reservation.id,
                        screening_id = seat.screening_id,
                        seat_id = seat.seat_id,
                    };
                    db.seat_reserved.Add(s);
                    db.SaveChanges();
                }

                b.reservation_id = _reservation.id;
                db.bills.Add(b);
                db.SaveChanges();

                foreach (detail_bill item in detail_Bills)
                {
                    item.bill_id = b.id;
                    var p = db.products.Find(item.product_id);
                    p.the_number_of_products -= item.the_number_of_products;

                    db.detail_bill.Add(item);
                    db.SaveChanges();
                }

                db.SaveChanges();
                id_reservation = _reservation.id;
            }
            return id_reservation;
        }

        public void UpdateReservation(int id_reservation, bool paid)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var r = db.reservations.Find(id_reservation);
                r.paid = paid;
                db.SaveChanges();
            }

        }

        internal void UpdateReservation(int id_reservation,int tempSum, int discount_point, int discount_pay, bool paid)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var r = db.reservations.Find(id_reservation);
                r.discount_pay = discount_pay;
                r.sum_pay = tempSum - discount_pay;
                r.paid = paid;

                var c = db.customers.Find(r.customer_id);
                c.discount_points -= discount_point;

                db.SaveChanges();
            }
        }

        public void CancelReservation(int id_reservation)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                var r = db.reservations.Find(id_reservation);
                var b = db.bills.Where(p => p.reservation_id == id_reservation).FirstOrDefault();
                var s = db.seat_reserved.Where(p => p.reservation_id == id_reservation);
                var d = db.detail_bill.Where(p => p.bill_id == b.id);
                
                db.seat_reserved.RemoveRange(s);
                db.SaveChanges();
                foreach (var item in d)
                {
                    var p = db.products.Where(c => c.id == item.product_id).FirstOrDefault();
                    p.the_number_of_products += item.the_number_of_products;
                }
                db.detail_bill.RemoveRange(d);
                db.SaveChanges();

                db.bills.Remove(b);
                db.SaveChanges();

                db.reservations.Remove(r);
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

        public List<HistoryInforTicket> GetListBookingByIdStaff(string id_staff)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                List<HistoryInforTicket> historyInforTickets = new List<HistoryInforTicket>();
                var l = db.reservations.Where(p => p.staff_id == id_staff)
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
                    (rsm, a) => new { rsm, a.name_auditorium }).OrderByDescending(sort => sort.rsm.rs.r.booking_date);
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

        public List<HistoryInforTicket> GetListBookingByIdScreening(int id_screening)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                List<HistoryInforTicket> historyInforTickets = new List<HistoryInforTicket>();
                var l = db.reservations
                    .Join(db.screenings,
                    r => r.screening_id,
                    s => s.id,
                    (r, s) => new { r, s }).
                    Where(p => p.s.id == id_screening).
                    Join(db.movies,
                    rs => rs.s.movie_id,
                    m => m.id,
                    (rs, m) => new { rs, m.title, m.poster }).
                    Join(db.auditoriums,
                    rsm => rsm.rs.s.auditorium_id,
                    a => a.id,
                    (rsm, a) => new { rsm, a.name_auditorium }).OrderByDescending(sort => sort.rsm.rs.r.booking_date);
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

        public reservation GetReservationById(int reservation_id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                return db.reservations.Find(reservation_id);
            }
        }

        public List<seat_reserved> GetReservedSeatByIdReservation(int id_reservation)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                List<int> idSeats = new List<int>();
                var list = db.seat_reserved.Where(p => p.reservation_id == id_reservation).ToList();
                return list;
            }
        }

        public List<detail_bill> GetListDetailBillByIdBill(int id_bill)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                var l = db.detail_bill.Where(p => p.bill_id == id_bill).ToList();
                return l;
            }
        }

        public int GetIdBillByIdReservation(int id_reservation)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.bills.Where(p => p.reservation_id == id_reservation).FirstOrDefault();
                return l.id;
            }
        }
    }
}
