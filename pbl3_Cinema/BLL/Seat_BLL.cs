using pbl3_Cinema.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.BLL
{
    internal class Seat_BLL
    {
        public int GetSeatReserved(int screen_id)
        {
            Seat_DAL dal = new Seat_DAL();
            return dal.GetSeatReserved(screen_id);
        }
        public List<seat_reserved> GetAllSeat_ReservedsById(int id_screening)
        {
            Seat_DAL dal = new Seat_DAL();
            return dal.GetAllSeat_ReservedsById(id_screening);
        }

        public List<seat> GetAllReservedSeatLocation(List<seat_reserved> seat_Reserveds)
        {
            Seat_DAL dal = new Seat_DAL();
            return dal.GetAllReservedSeatLocation(seat_Reserveds);
        }

        public seat_reserved GetSeat_Reserved(int screen_id, int seat_id)
        {
            Seat_DAL dal = new Seat_DAL();
            return dal.GetSeat_Reserved(screen_id, seat_id);
        }
    }
}
