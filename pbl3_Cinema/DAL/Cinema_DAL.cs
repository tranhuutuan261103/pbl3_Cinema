using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
