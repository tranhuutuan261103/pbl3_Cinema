using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.DAL
{
    internal class Cinema_DAL
    {
        public List<MyMovieInfor> GetAllMovieInforValidDay()
        {
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            using (CinemaEntities db =  new CinemaEntities())
            {
                var listMovie = db.movies.Where(p=>p.release_date <=  DateTime.Now && p.expiration_date >= DateTime.Now).Select(p=>new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category });
                foreach (var item in listMovie)
                {
                    list.Add(new MyMovieInfor
                    {
                        Id = item.id,
                        Title = item.title,
                        Description = item.description_movie,
                        ListCast = item.list_cast,
                        Director = item.director,
                        Duration_min = item.duration_min,
                        Release_date = item.release_date,
                        Expiration_date = item.expiration_date,
                        Category = new CBB_Category(item.category.id, item.category.name_category)
                    });
                }
                return list;
            }
        }

        public List<MyMovieInfor> GetAllMovieInforValidDay(int id_Category)
        {
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var listMovie = db.movies.Where(p => p.release_date <= DateTime.Now && p.expiration_date >= DateTime.Now && p.category_id == id_Category).Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category });
                foreach (var item in listMovie)
                {
                    list.Add(new MyMovieInfor
                    {
                        Id = item.id,
                        Title = item.title,
                        Description = item.description_movie,
                        ListCast = item.list_cast,
                        Director = item.director,
                        Duration_min = item.duration_min,
                        Release_date = item.release_date,
                        Expiration_date = item.expiration_date,
                        Category = new CBB_Category(item.category.id, item.category.name_category)
                    });
                }
                return list;
            }
        }

        public List<MyMovieInfor> GetAllMovieInforUpComing()
        {
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var listMovie = db.movies.Where(p => p.release_date >= DateTime.Now ).Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category });
                foreach (var item in listMovie)
                {
                    list.Add(new MyMovieInfor
                    {
                        Id = item.id,
                        Title = item.title,
                        Description = item.description_movie,
                        ListCast = item.list_cast,
                        Director = item.director,
                        Duration_min = item.duration_min,
                        Release_date = item.release_date,
                        Expiration_date = item.expiration_date,
                        Category = new CBB_Category(item.category.id, item.category.name_category)
                    });
                }
                return list;
            }
        }

        public List<CBBMovie> GetCBBMoviesNow()
        {
            List<CBBMovie> list = new List<CBBMovie>();
            using(CinemaEntities db = new CinemaEntities())
            {
                var l = db.movies.Where(p => p.expiration_date >= DateTime.Now).Select(p => new { p.id, p.title });
                foreach (var item in l)
                {
                    list.Add(new CBBMovie
                    {
                        id_movie = item.id,
                        title = item.title,
                    });
                }
            }
            return list;
        }

        public int GetDurationOfMovie(int id_movie)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var minute = db.movies.Where(p => p.id == id_movie).Select(p => new { p.duration_min }).FirstOrDefault();
                if (minute != null)
                {
                    return minute.duration_min;
                }
                return 0;
            }
        }

        public byte[] GetPosterById(int id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var image = db.movies.Where(p=>p.id == id).Select(p => p.poster).FirstOrDefault();
                if (image == null)
                {
                    return null;
                }
                return image;
            }
        }

        public List<Auditorium_Infor> GetAllAuditorium_Infor()
        {
            List<Auditorium_Infor> list = new List<Auditorium_Infor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.auditoriums.
                    Where(p => p.active == true).
                    GroupJoin(db.screenings.Where(p=>p.show_day>=DateTime.Now).GroupBy(infor => infor.auditorium_id).Select(p=> new { audi_id = p.Key, count = p.Count()}), 
                    k1 => k1.id,
                    k2 => k2.audi_id,
                    (k1,k2)=> new {k1,k2})
                    .SelectMany(x=>x.k2.DefaultIfEmpty(),
                    (k1,k2) => new {k1.k1.id, k1.k1.name_auditorium, k1.k1.seat_no_row, k1.k1.seat_no_column, count = k2==null?0:k2.count});

                foreach (var auditorium in l)
                {
                    list.Add(new Auditorium_Infor
                    {
                        id = auditorium.id,
                        name_auditorium = auditorium.name_auditorium,
                        seat_no_row = auditorium.seat_no_row,
                        seat_no_column = auditorium.seat_no_column,
                        screening_curent_count = auditorium.count,
                    });
                }
            }
            return list;
        }

        public int AddSeat(int id_auditorium, int seat_row, int seat_column)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                for (int i = 1;i <= seat_row; i++)
                {
                    for (int j = 1;j <= seat_column; j++)
                    {
                        seat s = new seat
                        {
                            auditorium_id = id_auditorium,
                            row_location = i,
                            column_location = j,
                        };
                        db.seats.Add(s);
                        db.SaveChanges();
                    }
                }
            }
            return 1;
        }

        public int AddAuditorium(auditorium a)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var l = db.auditoriums.Add(a);
                    db.SaveChanges();
                    AddSeat(a.id, a.seat_no_row, a.seat_no_column);
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public bool CanAddScreening(DateTime start, DateTime end)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var listScreeningNow = db.screenings.Select(p => new { p.id, p.show_day, p.show_time, p.movie_id }).
                    Join(db.movies,
                    s => s.movie_id,
                    m => m.id,
                    (s, m) => new { s.id, s.show_day, s.show_time, s.movie_id, m.duration_min });
                foreach ( var item in listScreeningNow)
                {
                    DateTime s = item.show_day + item.show_time;
                    DateTime e = s + new TimeSpan(0,item.duration_min,0);
                    if ( !(start>e || end<s) == true )
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int AddScreening(screening screen)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.screenings.Add(screen);
                db.SaveChanges();
            }
            return 1;
        }

        public int GetScreeningCurCount(int id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var count = db.screenings.Where(p=>p.show_day>=DateTime.Now && p.auditorium_id==id).Count();
                return count;
            }
        }

        public bool DeleteAuditorium(int id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var result = db.auditoriums.Where(p => p.id == id).FirstOrDefault();
                    result.active = false;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<CBBAuditorium> GetAllCBBAuditorimActive()
        {
            List<CBBAuditorium> listCBB = new List<CBBAuditorium> ();
            using (CinemaEntities db = new CinemaEntities())
            {
                var list = db.auditoriums.Where(p=>p.active==true).Select(p=>new {p.id,p.name_auditorium});
                foreach (var item in list)
                {
                    listCBB.Add(new CBBAuditorium
                    {
                        id = item.id,
                        nameAuditorium = item.name_auditorium,
                    });
                }
            }
            return listCBB;
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
                    (m, n) => new { m.m.m.m.id, m.m.m.title, m.m.name_auditorium, m.m.m.m.show_day, m.m.m.m.show_time, sumseat = m.m.seat_no_row * m.m.seat_no_column, m.m.m.m.price, count = n==null?0:n.count }
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
                    if ( l.show_day + l.show_time >= DateTime.Now.AddMinutes(30))
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
            List<ScreeningInfor> list = new List<ScreeningInfor> ();
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

        public DateTime GetDateTimeScreeningInfor(int screen_id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var o = db.screenings.Where(p=>p.id == screen_id).Select(p => new {p.id, p.show_day, p.show_time}).FirstOrDefault();
                return o.show_day + o.show_time;
            }
        }

        public int GetSeatReserved(int screen_id)
        {
            using (CinemaEntities db= new CinemaEntities())
            {
                var o = db.seat_reserved.Where(p => p.screening_id == screen_id).GroupBy(p => p.screening_id).Select(p => new { p.Key, count = p.Count() }).FirstOrDefault();
                return (o==null)? 0 : o.count;
            }
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
    }
}
