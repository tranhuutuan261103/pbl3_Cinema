using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class User_Infor
    {
        public string email { set; get; }
        public string nameUser { set; get; }
        public string Gender { set; get; }
        public string PhoneNumber { set; get; }
        public DateTime DayOfBirth { set; get; }
        public bool Active { set; get; }
    }
}
