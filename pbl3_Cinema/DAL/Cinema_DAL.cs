using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

        public int AddAuditorium(auditorium a)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var l = db.auditoriums.Add(a);
                    db.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
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
    }
}
