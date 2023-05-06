using pbl3_Cinema.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;

namespace pbl3_Cinema.BLL
{
    internal class Rating_BLL
    {
        public int AddRating(rating r)
        {
            Rating_DAL dal = new Rating_DAL();
            return dal.AddRating(r);
        }

        public List<rating> GetAllRatingsByIdMovie(int id_movie)
        {
            Rating_DAL dal = new Rating_DAL();
            return dal.GetAllRatingsByIdMovie(id_movie);
        }

        public double GetPointRating(int id_movie)
        {
            List<rating> list = GetAllRatingsByIdMovie(id_movie);
            if (list.Count == 0)
            {
                return 0;
            }
            int point = 0;
            foreach (rating r in list)
            {
                point += r.point;
            }
            return point/list.Count;
        }

        public int GetRatingCountByIdMovie(int id_movie)
        {
            List<rating> list = GetAllRatingsByIdMovie(id_movie);
            return list.Count;
        }
    }
}
