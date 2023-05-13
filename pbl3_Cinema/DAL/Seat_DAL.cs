using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DAL
{
    internal class Seat_DAL
    {
        public List<seat> GetAllReservedSeatLocation(List<seat_reserved> seat_Reserveds)
        {
            List<seat> listSeat = new List<seat>();
            using (CinemaEntities db = new CinemaEntities())
            {
                foreach (var s in seat_Reserveds)
                {
                    var l = db.seats.Where(p => p.id == s.seat_id).FirstOrDefault();
                    listSeat.Add(l);
                }
            }
            return listSeat;
        }

        public List<seat_reserved> GetAllSeat_ReservedsById(int id_screening)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.seat_reserved.Where(p => p.screening_id == id_screening);
                return l.ToList();
            }
        }

        public int GetSeatReserved(int screen_id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var o = db.seat_reserved.Where(p => p.screening_id == screen_id).GroupBy(p => p.screening_id).Select(p => new { p.Key, count = p.Count() }).FirstOrDefault();
                return (o == null) ? 0 : o.count;
            }
        }
    }
}
