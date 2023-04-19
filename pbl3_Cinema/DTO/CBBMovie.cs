using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class CBBMovie
    {
        public int id_movie { set ; get; }
        public string title { set ; get; }
        public override string ToString()
        {
            return title;
        }
    }
}
