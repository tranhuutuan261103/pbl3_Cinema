using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.BLL
{
    internal class Auditorium_BLL
    {
        public int AddAuditorium(auditorium a)
        {
            Auditorium_DAL dal = new Auditorium_DAL();
            return dal.AddAuditorium(a);
        }

        public bool DeleteAuditorium(int id)
        {
            Auditorium_DAL dal = new Auditorium_DAL();
            return dal.DeleteAuditorium(id);
        }

        public List<Auditorium_Infor> GetAllAuditorium_Infor()
        {
            Auditorium_DAL dal = new Auditorium_DAL();
            return dal.GetAllAuditorium_Infor();
        }

        public List<CBBAuditorium> GetAllCBBAuditorimActive()
        {
            Auditorium_DAL dal = new Auditorium_DAL();
            return dal.GetAllCBBAuditorimActive();
        }

        public auditorium GetAuditoriumByIdScreening(int id_screening)
        {
            Auditorium_DAL dal = new Auditorium_DAL();
            return dal.GetAuditoriumByIdScreening(id_screening);
        }
    }
}
