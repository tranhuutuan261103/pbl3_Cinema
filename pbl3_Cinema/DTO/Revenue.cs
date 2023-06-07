using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class Revenue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name_Auditorium { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Sum { get; set; }
        public int Seat_Sum { get; set; }
    }
}
