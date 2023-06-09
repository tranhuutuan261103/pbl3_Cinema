using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.DAL
{
    internal class Revenue_DAL
    {
        public List<Revenue> GetRevenueByMovie(int id_movie, DateTime start, DateTime end)
        {
            List<Revenue> list = new List<Revenue>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.screenings.Join(db.movies, s => s.movie_id, m => m.id, (s, m) => new { s, s.movie.title }).
                    Join(db.auditoriums, s => s.s.auditorium_id, a => a.id, (s, a) => new { s, a.name_auditorium }).
                    GroupJoin(db.reservations.GroupBy(r => new { r.screening_id}).Select(r => new {r.Key, sumPay = r.Sum(rs => rs.sum_pay)}), s => s.s.s.id, r => r.Key.screening_id, (s, r) => new { s, r }).
                    SelectMany(
                        x => x.r.DefaultIfEmpty(),
                        (x, r) => new { x.s.s.s, x.s.s.title, x.s.name_auditorium, sumPay = r == null ? 0 : r.sumPay }
                    ).
                    GroupJoin(db.seat_reserved.GroupBy(sr => sr.screening_id).Select(sr => new { sr.Key, seat_sum = sr.Count() }), s => s.s.id, sr => sr.Key, (s, sr) => new { s, sr }).
                    SelectMany(
                        x => x.sr.DefaultIfEmpty(),
                        (x, sr) => new { x.s.s, x.s.title, x.s.name_auditorium, x.s.sumPay, seat_sum = sr == null ? 0 : sr.seat_sum }
                    ).Where(s => s.s.show_day >= start && s.s.show_day <= end && s.s.movie_id == id_movie
                    );
                    
                var li = db.seat_reserved.GroupBy(sr => sr.screening_id).Select(sr => new { sr.Key, seat_sum = sr.Count() });
                foreach (var item in l)
                {
                    list.Add(new Revenue()
                    {
                        Id = item.s.id,
                        Title = item.title,
                        Name_Auditorium = item.name_auditorium,
                        Date = item.s.show_day,
                        Time = item.s.show_time,
                        Sum = item.sumPay,
                        Seat_Sum = item.seat_sum
                    });
                }
            }
            return list;
        }

        public List<Revenue> GetRevenueByMovie(DateTime start, DateTime end)
        {
            List<Revenue> list = new List<Revenue>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.screenings.Join(db.movies, s => s.movie_id, m => m.id, (s, m) => new { s, s.movie.title }).
                    Join(db.auditoriums, s => s.s.auditorium_id, a => a.id, (s, a) => new { s, a.name_auditorium }).
                    GroupJoin(db.reservations.GroupBy(r => new { r.screening_id }).Select(r => new { r.Key, sumPay = r.Sum(rs => rs.sum_pay) }), s => s.s.s.id, r => r.Key.screening_id, (s, r) => new { s, r }).
                    SelectMany(
                        x => x.r.DefaultIfEmpty(),
                        (x, r) => new { x.s.s.s, x.s.s.title, x.s.name_auditorium, sumPay = r == null ? 0 : r.sumPay }
                    ).
                    GroupJoin(db.seat_reserved.GroupBy(sr => sr.screening_id).Select(sr => new { sr.Key, seat_sum = sr.Count() }), s => s.s.id, sr => sr.Key, (s, sr) => new { s, sr }).
                    SelectMany(
                        x => x.sr.DefaultIfEmpty(),
                        (x, sr) => new { x.s.s, x.s.title, x.s.name_auditorium, x.s.sumPay, seat_sum = sr == null ? 0 : sr.seat_sum }
                    ).Where(s => s.s.show_day >= start && s.s.show_day <= end 
                    );

                var li = db.seat_reserved.GroupBy(sr => sr.screening_id).Select(sr => new { sr.Key, seat_sum = sr.Count() });
                foreach (var item in l)
                {
                    list.Add(new Revenue()
                    {
                        Id = item.s.id,
                        Title = item.title,
                        Name_Auditorium = item.name_auditorium,
                        Date = item.s.show_day,
                        Time = item.s.show_time,
                        Sum = item.sumPay,
                        Seat_Sum = item.seat_sum
                    });
                }
            }
            return list;
        }

        public List<reservation> GetAllReservationById(int id_screening)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                return db.reservations.Where(r => r.screening_id == id_screening).ToList();
            }
        }

        public ScreeningInfor GetInfor(int id_screening)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var item = db.screenings.Join(db.movies, s => s.movie_id, m => m.id, (s, m) => new { s, m.title }).
                    Join(db.auditoriums, s => s.s.auditorium_id, a => a.id, (s, a) => new { s, a.name_auditorium }).
                    Where(s => s.s.s.id == id_screening).FirstOrDefault();
                return new ScreeningInfor()
                {
                    id = item.s.s.id,
                    nameMovie = item.s.title,
                    nameAuditorium = item.name_auditorium,
                    ShowDay = item.s.s.show_day,
                    ShowTime = item.s.s.show_time
                };
            }
        }
    }
}
