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
        internal int AddCategory(category c)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                db.categories.Add(c);
                db.SaveChanges();
                return 1;
            }
        }
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
            var list = entities.movies.Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category, p.video_trailer });
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
                    Category = new CBB_Category(movie.category.id, movie.category.name_category),
                    Video_trailer = movie.video_trailer
                });
            }
            return listMovie;
        }

        public void AddFilm(movie Movie)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    db.movies.Add(Movie);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ");
                }
            }
        }

        public void UpdateFilm(movie Movie)
        {
            try
            {
                using (CinemaEntities db = new CinemaEntities())
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

                    s.video_trailer = Movie.video_trailer;

                    db.SaveChanges();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            
        }

        public bool CheckCanDeleteMovie(int id_movie)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var n = db.screenings.Where(p => p.movie_id == id_movie).Count();
                if (n > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void DeleteFilm(int id)
        {
            if (CheckCanDeleteMovie(id) == false)
            {
                MessageBox.Show("Không thể xóa phim này vì đã có lịch chiếu");
                return;
            }
            using (CinemaEntities db = new CinemaEntities())
            {
                var listRating = db.ratings.Where(p => p.movie_id == id).ToList();
                listRating.RemoveAll(p => p.movie_id == id);
                db.SaveChanges();
                var s = db.movies.Where(p => p.id == id).FirstOrDefault();
                db.movies.Remove(s);
                db.SaveChanges();
            }
        }

        public MyMovieInfor GetMovieById(int id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var movie = db.movies.Where(p => p.id == id).Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category, p.video_trailer }).FirstOrDefault();
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
                        Category = new CBB_Category(movie.category.id, movie.category.name_category),
                        Video_trailer = movie.video_trailer
                    };
                }
            }
        }

        public List<MyMovieInfor> GetAllMovieInforValidDay()
        {
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            using (CinemaEntities db =  new CinemaEntities())
            {
                var listMovie = db.movies.Where(p=>p.release_date <=  DateTime.Now && p.expiration_date >= DateTime.Now).Select(p=>new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category, p.video_trailer });
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
                        Category = new CBB_Category(item.category.id, item.category.name_category),
                        Video_trailer = item.video_trailer
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
                var listMovie = db.movies.Where(p => p.release_date <= DateTime.Now && p.expiration_date >= DateTime.Now && p.category_id == id_Category).Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category, p.video_trailer });
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
                        Category = new CBB_Category(item.category.id, item.category.name_category),
                        Video_trailer = item.video_trailer
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
                var listMovie = db.movies.Where(p => p.release_date >= DateTime.Now ).Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category, p.video_trailer });
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
                        Category = new CBB_Category(item.category.id, item.category.name_category),
                        Video_trailer = item.video_trailer
                    });
                }
                return list;
            }
        }

        public List<MyMovieInfor> GetAllMovieInforUpComing(int id_Category)
        {
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var listMovie = db.movies.Where(p => p.release_date >= DateTime.Now && p.category_id == id_Category).Select(p => new { p.id, p.title, p.description_movie, p.director, p.list_cast, p.duration_min, p.release_date, p.expiration_date, p.category, p.video_trailer });
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
                        Category = new CBB_Category(item.category.id, item.category.name_category),
                        Video_trailer = item.video_trailer
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

        public List<CBBMovie> GetCBBMovies()
        {
            List<CBBMovie> list = new List<CBBMovie>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.movies.Select(p => new { p.id, p.title });
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

    }
}
