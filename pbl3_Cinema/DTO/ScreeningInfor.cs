using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class ScreeningInfor
    {
        public int id { set; get; }
        public string nameMovie { set; get; }
        public string nameAuditorium { set; get; }
        public DateTime ShowDay { set; get; }
        public TimeSpan ShowTime { set; get; }
        public int SumSeatReserved { set; get; }
        public int SumSeat { set; get; }
        public int price { set; get; }
        
    }
}
