using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.BLL
{
    internal class Revenue_BLL
    {
        public List<Revenue> GetRevenueByMovie(int id_movie, DateTime start, DateTime end)
        {
            Revenue_DAL dal = new Revenue_DAL();
            return dal.GetRevenueByMovie(id_movie, start, end);
        }

        public List<Revenue> GetRevenueByMovie(DateTime start, DateTime end)
        {
            Revenue_DAL dal = new Revenue_DAL();
            return dal.GetRevenueByMovie(start, end);
        }
    }
}
