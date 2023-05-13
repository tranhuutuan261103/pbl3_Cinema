using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DAL
{
    internal class Screening_DAL
    {
        public int AddScreening(screening screen)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var s = db.screenings.Add(screen);
                db.SaveChanges();
            }
            return 1;
        }

        public bool CanAddScreening(DateTime start, DateTime end, int id_auditorium)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var listScreeningNow = db.screenings.Where(p => p.auditorium_id == id_auditorium).Select(p => new { p.id, p.show_day, p.show_time, p.movie_id }).
                    Join(db.movies,
                    s => s.movie_id,
                    m => m.id,
                    (s, m) => new { s.id, s.show_day, s.show_time, s.movie_id, m.duration_min });
                foreach (var item in listScreeningNow)
                {
                    DateTime s = item.show_day + item.show_time;
                    DateTime e = s + new TimeSpan(0, item.duration_min, 0);
                    if (!(start > e || end < s) == true)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int UpdateScreening(screening screen)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var s = db.screenings.Find(screen.id);
                s.auditorium_id = screen.auditorium_id;
                s.movie_id = screen.movie_id;
                s.price = screen.price;
                s.show_day = screen.show_day;
                s.show_time = screen.show_time;
                db.SaveChanges();
            }
            return 1;
        }

        public int DeleteScreeningById(int screen_id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    screening s = new screening()
                    {
                        id = screen_id,
                    };
                    db.screenings.Attach(s);
                    db.screenings.Remove(s);
                    db.SaveChanges();
                }
                catch
                {
                    return 0;
                }
            }
            return 1;
        }

        public int GetScreeningCurCount(int id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var count = db.screenings.Where(p => p.show_day >= DateTime.Now && p.auditorium_id == id).Count();
                return count;
            }
        }

        public List<ScreeningInfor> GetScreeningInforsFilter(DateTime dateTime, int id_auditorium)
        {
            List<ScreeningInfor> listScreening = new List<ScreeningInfor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var list = db.screenings.
                    Where(p => p.show_day.Year == dateTime.Year && p.show_day.Month == dateTime.Month && p.show_day.Day == dateTime.Day).
                    Join(db.movies,
                    m => m.movie_id,
                    n => n.id,
                    (m, n) => new { m, n.title }).
                    Join(db.auditoriums,
                    m => m.m.auditorium_id,
                    n => n.id,
                    (m, n) => new { m, id_audi = n.id, n.name_auditorium, n.seat_no_row, n.seat_no_column }).
                    Where(p => p.id_audi == id_auditorium).
                    GroupJoin(db.seat_reserved.GroupBy(p => p.screening_id).Select(p => new { screen_id = p.Key, count = p.Count() }),
                    m => m.m.m.id,
                    n => n.screen_id,
                    (m, n) => new { m, n })
                    .SelectMany(
                    x => x.n.DefaultIfEmpty(),
                    (m, n) => new { m.m.m.m.id, m.m.m.title, m.m.name_auditorium, m.m.m.m.show_day, m.m.m.m.show_time, sumseat = m.m.seat_no_row * m.m.seat_no_column, m.m.m.m.price, count = n == null ? 0 : n.count }
                    );
                foreach (var l in list)
                {
                    listScreening.Add(new ScreeningInfor
                    {
                        id = l.id,
                        nameAuditorium = l.name_auditorium,
                        nameMovie = l.title,
                        ShowDay = l.show_day,
                        ShowTime = l.show_time,
                        SumSeat = l.sumseat,
                        SumSeatReserved = l.count,
                        price = l.price,
                    });
                }
            }
            return listScreening;
        }

        public List<ScreeningInfor> GetScreeningInforsFilterIdMovie(DateTime dateTime, int id_movie)
        {
            List<ScreeningInfor> listScreening = new List<ScreeningInfor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var list = db.screenings.
                    Where(p => p.show_day.Year == dateTime.Year && p.show_day.Month == dateTime.Month && p.show_day.Day == dateTime.Day && p.movie_id == id_movie).
                    Join(db.movies,
                    m => m.movie_id,
                    n => n.id,
                    (m, n) => new { m, n.title }).
                    Join(db.auditoriums,
                    m => m.m.auditorium_id,
                    n => n.id,
                    (m, n) => new { m, id_audi = n.id, n.name_auditorium, n.seat_no_row, n.seat_no_column }).
                    GroupJoin(db.seat_reserved.GroupBy(p => p.screening_id).Select(p => new { screen_id = p.Key, count = p.Count() }),
                    m => m.m.m.id,
                    n => n.screen_id,
                    (m, n) => new { m, n })
                    .SelectMany(
                    x => x.n.DefaultIfEmpty(),
                    (m, n) => new { m.m.m.m.id, m.m.m.title, m.m.name_auditorium, m.m.m.m.show_day, m.m.m.m.show_time, sumseat = m.m.seat_no_row * m.m.seat_no_column, m.m.m.m.price, count = n == null ? 0 : n.count }
                    );
                foreach (var l in list)
                {
                    if (l.show_day + l.show_time >= DateTime.Now.AddMinutes(30))
                    {
                        listScreening.Add(new ScreeningInfor
                        {
                            id = l.id,
                            nameAuditorium = l.name_auditorium,
                            nameMovie = l.title,
                            ShowDay = l.show_day,
                            ShowTime = l.show_time,
                            SumSeat = l.sumseat,
                            SumSeatReserved = l.count,
                            price = l.price,
                        });
                    }
                }
            }
            return listScreening;
        }

        public List<ScreeningInfor> GetAllScreeningInfor()
        {
            List<ScreeningInfor> list = new List<ScreeningInfor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.screenings.
                    Join(db.movies,
                    m => m.movie_id,
                    n => n.id,
                    (m, n) => new { m, n.title }).
                    Join(db.auditoriums,
                    m => m.m.auditorium_id,
                    n => n.id,
                    (m, n) => new { m, id_audi = n.id, n.name_auditorium, n.seat_no_row, n.seat_no_column }).
                    GroupJoin(db.seat_reserved.GroupBy(p => p.screening_id).Select(p => new { screen_id = p.Key, count = p.Count() }),
                    m => m.m.m.id,
                    n => n.screen_id,
                    (m, n) => new { m, n })
                    .SelectMany(
                    x => x.n.DefaultIfEmpty(),
                    (m, n) => new { m.m.m.m.id, m.m.m.title, m.m.name_auditorium, m.m.m.m.show_day, m.m.m.m.show_time, sumseat = m.m.seat_no_row * m.m.seat_no_column, m.m.m.m.price, count = n == null ? 0 : n.count }
                    );
                foreach (var item in l)
                {
                    list.Add(new ScreeningInfor
                    {
                        id = item.id,
                        nameAuditorium = item.name_auditorium,
                        nameMovie = item.title,
                        ShowDay = item.show_day,
                        ShowTime = item.show_time,
                        SumSeat = item.sumseat,
                        SumSeatReserved = item.count,
                        price = item.price,
                    });
                }
            }
            return list;
        }

        public List<ScreeningInfor> GetScreeningInforsFilter(DateTime dateTime)
        {
            List<ScreeningInfor> listScreening = new List<ScreeningInfor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var list = db.screenings.
                    Where(p => p.show_day.Year == dateTime.Year && p.show_day.Month == dateTime.Month && p.show_day.Day == dateTime.Day).
                    Join(db.movies,
                    m => m.movie_id,
                    n => n.id,
                    (m, n) => new { m, n.title }).
                    Join(db.auditoriums,
                    m => m.m.auditorium_id,
                    n => n.id,
                    (m, n) => new { m, n.name_auditorium, n.seat_no_row, n.seat_no_column }).
                    GroupJoin(db.seat_reserved.GroupBy(p => p.screening_id).Select(p => new { screen_id = p.Key, count = p.Count() }),
                    m => m.m.m.id,
                    n => n.screen_id,
                    (m, n) => new { m, n })
                    .SelectMany(
                    x => x.n.DefaultIfEmpty(),
                    (m, n) => new { m.m.m.m.id, m.m.m.title, m.m.name_auditorium, m.m.m.m.show_day, m.m.m.m.show_time, sumseat = m.m.seat_no_row * m.m.seat_no_column, m.m.m.m.price, count = n == null ? 0 : n.count }
                    );
                foreach (var l in list)
                {
                    listScreening.Add(new ScreeningInfor
                    {
                        id = l.id,
                        nameAuditorium = l.name_auditorium,
                        nameMovie = l.title,
                        ShowDay = l.show_day,
                        ShowTime = l.show_time,
                        SumSeat = l.sumseat,
                        SumSeatReserved = l.count,
                        price = l.price,
                    });
                }
            }
            return listScreening;
        }

        public ScreeningInfor GetScreeningInforById(int id_screening)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var s = db.screenings.Where(p => p.id == id_screening).Select(p => p).FirstOrDefault();
                return new ScreeningInfor
                {
                    id = s.id,
                    ShowDay = s.show_day,
                    ShowTime = s.show_time,
                    nameAuditorium = s.auditorium.name_auditorium,
                    nameMovie = s.movie.title,
                    price = s.price,
                };
            }
        }

        public screening GetScreeningById(int id_screening)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var screen = db.screenings.Where(p => p.id == id_screening).Select(p => p).FirstOrDefault();
                return screen;
            }
        }
        public DateTime GetDateTimeScreeningInfor(int screen_id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var o = db.screenings.Where(p => p.id == screen_id).Select(p => new { p.id, p.show_day, p.show_time }).FirstOrDefault();
                return o.show_day + o.show_time;
            }
        }
    }
}
