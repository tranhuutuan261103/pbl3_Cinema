using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class CBBAuditorium
    {
        public int id { set; get; }
        public string nameAuditorium { set; get; }
        public override string ToString()
        {
            return nameAuditorium;
        }
    }
}
