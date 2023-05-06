using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DAL
{
    internal class Rating_DAL
    {
        public int AddRating(rating r)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    db.ratings.Add(r);
                    db.SaveChanges();
                }
                catch
                {
                    return 0;
                }
            }
            return 1;
        }

        public List<rating> GetAllRatingsByIdMovie(int id_movie)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.ratings.Where(p => p.movie_id == id_movie);
                return l.ToList();
            }
        }

    }
}
