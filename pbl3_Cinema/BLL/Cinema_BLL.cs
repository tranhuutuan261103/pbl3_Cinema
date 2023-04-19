using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.BLL
{
    internal class Cinema_BLL
    {
        public List<CBB_Category> GetAllCBBCategory()
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                List<CBB_Category> listCBB = new List<CBB_Category>();
                var list = db.categories.Select(p => new { p.id, p.name_category });
                foreach (var category in list)
                {
                    listCBB.Add(new CBB_Category() { id = category.id, name_Category = category.name_category });
                }
                return listCBB;
            }
        }

        public List<MyMovieInfor> GetAllMovieInfor()
        {
            CinemaEntities entities = new CinemaEntities();
            List<MyMovieInfor> listMovie = new List<MyMovieInfor>();
            var list = entities.movies.Select(p => new { p.id, p.title,p.description_movie,p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category });
            foreach (var movie in list)
            {
                listMovie.Add(new MyMovieInfor
                {
                    Id = movie.id,
                    Title = movie.title,
                    Description = movie.description_movie,
                    ListCast = movie.list_cast,
                    Director = movie.director,
                    Duration_min = movie.duration_min,
                    Release_date = movie.release_date,
                    Expiration_date = movie.expiration_date,
                    Category = new CBB_Category(movie.category.id, movie.category.name_category)
                });
            }
            return listMovie;
        }

        public List<movie> GetAllMovie()
        {
            CinemaEntities db = new CinemaEntities();
            List<movie> listMovie = new List<movie>();
            var list = db.movies.Select(p => p);
            foreach (var movie in list)
            {
                listMovie.Add(movie);
            }
            return listMovie;
        }

        public void AddFilm(movie Movie)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                db.movies.Add(Movie);
                db.SaveChanges();
            }
        }

        public void UpdateFilm(movie Movie)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                var s = db.movies.Where(p => p.id == Movie.id).FirstOrDefault();

                s.title = Movie.title;
                s.description_movie = Movie.description_movie;
                s.director = Movie.director;
                s.list_cast = Movie.list_cast;
                s.duration_min = Movie.duration_min;
                s.category_id = Movie.category_id;
                s.release_date = Movie.release_date;
                s.expiration_date = Movie.expiration_date;
                if (Movie.poster != null)
                {
                    s.poster = Movie.poster;
                }
                
                if (Movie.video_trailer != null)
                {
                    s.video_trailer = Movie.video_trailer;
                }

                db.SaveChanges();
            }
        }

        //public void AddVideoTrailer(video_trailer vt)
        //{
        //    using(CinemaEntities db = new CinemaEntities())
        //    {
        //        db.video_trailer.AddOrUpdate(vt);
        //        db.SaveChanges();
        //    }
        //}

        public MyMovieInfor GetMovieById(int id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var movie = db.movies.Where(p=>p.id == id).Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category }).FirstOrDefault();
                {
                    return new MyMovieInfor
                    {
                        Id = movie.id,
                        Title = movie.title,
                        Description = movie.description_movie,
                        ListCast = movie.list_cast,
                        Director = movie.director,
                        Duration_min = movie.duration_min,
                        Release_date = movie.release_date,
                        Expiration_date = movie.expiration_date,
                        Category = new CBB_Category(movie.category.id, movie.category.name_category)
                    };
                }
            }
        }

        public List<MyMovieInfor> GetAllMovieInforValidDay(int id_Category)
        {
            Cinema_DAL dal = new Cinema_DAL();
            if (id_Category == 0)
            {
                return dal.GetAllMovieInforValidDay();
            }
            return dal.GetAllMovieInforValidDay(id_Category);
        }

        public List<MyMovieInfor> GetAllMovieInforUpComing()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetAllMovieInforUpComing();
        }

        public List<CBBMovie> GetCBBMoviesNow()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetCBBMoviesNow();
        }

        public int GetDurationOfMovie(int id_movie)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetDurationOfMovie(id_movie);
        }

        public Image GetPosterById(int id)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return MyFuncStatic.MyConvert.ConvertBinaryToImage(dal.GetPosterById(id));
        }

        public List<Auditorium_Infor> GetAllAuditorium_Infor()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetAllAuditorium_Infor();
        }

        public int AddAuditorium(auditorium a)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.AddAuditorium(a);
        }

        public bool CanAddScreening(DateTime start, DateTime end)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.CanAddScreening(start, end);
        }

        public int AddScreening(screening screen)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.AddScreening(screen);
        }

        public int GetScreeningCurCount(int id)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetScreeningCurCount(id);
        }

        public bool DeleteAuditorium(int id)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.DeleteAuditorium(id);
        }

        public List<CBBAuditorium> GetAllCBBAuditorimActive()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetAllCBBAuditorimActive();
        }

        public List<ScreeningInfor> GetScreeningInforsFilter(DateTime dateTime)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetScreeningInforsFilter(dateTime);
        }

        public List<ScreeningInfor> GetScreeningInforsFilter(DateTime dateTime, int id_auditorium)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetScreeningInforsFilter(dateTime, id_auditorium);
        }

        public List<ScreeningInfor> GetScreeningInforsFilterIdMovie(DateTime dateTime, int id_movie)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetScreeningInforsFilterIdMovie(dateTime, id_movie);
        }

        public List<ScreeningInfor> GetAllScreeningInfor()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetAllScreeningInfor();
        }

        public bool CanDeleteScreening(int screen_id)
        {
            Cinema_DAL dal = new Cinema_DAL();
            if (dal.GetDateTimeScreeningInfor(screen_id) <= DateTime.Now.AddMinutes(30))
            {
                MessageBox.Show("Không thể xóa");
                return false;
            }
            int n = dal.GetSeatReserved(screen_id);
            if (n > 0)
            {
                MessageBox.Show("Đã có " + n + " ghế đã đặt!");
                return false;
            }
            return true;
        }

        public int DeleteScreeningById(int screen_id)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.DeleteScreeningById(screen_id);
        }
    }
}
