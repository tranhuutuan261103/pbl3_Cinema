using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class HistoryInforTicket
    {
        public int id { set; get; }

        public int id_auditorium { set; get; }
        public string name_auditorium{ set; get; }
        public int id_movie { set; get; }
        public string title { set; get; }
        public Image image { set; get; }
        public DateTime bookingDay { set; get; }
        public int id_screening { set; get; }
        public DateTime showDay{set; get; }
        public TimeSpan showTime { set; get; }
    }
}
