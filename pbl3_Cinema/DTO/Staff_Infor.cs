using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class Staff_Infor:User_Infor
    {
        public string position { get; set; }
        public int wage { get; set; }
    }
}
