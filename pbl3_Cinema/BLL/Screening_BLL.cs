using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.BLL
{
    internal class Screening_BLL
    {
        public int AddScreening(screening screen)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.AddScreening(screen);
        }

        public bool CanAddScreening(DateTime start, DateTime end, int id_auditorium)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.CanAddScreening(start, end, id_auditorium);
        }

        public int UpdateScreening(screening s)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.UpdateScreening(s);
        }

        public int DeleteScreeningById(int screen_id)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.DeleteScreeningById(screen_id);
        }

        public int GetScreeningCurCount(int id)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.GetScreeningCurCount(id);
        }

        public List<ScreeningInfor> GetScreeningInforsFilter(DateTime dateTime, int id_auditorium)
        {
            Screening_DAL dal = new Screening_DAL();
            List<ScreeningInfor> list = new List<ScreeningInfor>();
            foreach (ScreeningInfor s in dal.GetScreeningInforsFilter(dateTime, id_auditorium))
            {
                if (s.ShowDay + s.ShowTime >= DateTime.Now.AddMinutes(30))
                {
                    list.Add(s);
                }
            }
            return list;
        }

        // get all screeing
        public List<ScreeningInfor> GetAllScreeningInforsFilter(DateTime dateTime, int id_auditorium)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.GetScreeningInforsFilter(dateTime, id_auditorium);
        }

        public List<ScreeningInfor> GetScreeningInforsFilterIdMovie(DateTime dateTime, int id_movie)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.GetScreeningInforsFilterIdMovie(dateTime, id_movie);
        }

        public List<ScreeningInfor> GetAllScreeningInforsFilter(DateTime dateTime)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.GetScreeningInforsFilter(dateTime);
        }

        public List<ScreeningInfor> GetAllScreeningInfor()
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.GetAllScreeningInfor();
        }

        public ScreeningInfor GetScreeningInforById(int id_screening)
        {
            Screening_DAL dal = new Screening_DAL();
            foreach(ScreeningInfor s in dal.GetAllScreeningInfor())
            {
                if (s.id == id_screening)
                {
                    return s;
                }
            }
            return null;
        }

        public screening GetScreeningById(int id_screening)
        {
            Screening_DAL dal = new Screening_DAL();
            return dal.GetScreeningById(id_screening);
        }

        public bool CanDeleteScreening(int screen_id)
        {
            Screening_DAL dal = new Screening_DAL();
            Seat_BLL seat_BLL = new Seat_BLL();
            if (dal.GetDateTimeScreeningInfor(screen_id) <= DateTime.Now.AddMinutes(30))
            {
                MessageBox.Show("Không thể xóa");
                return false;
            }

            int n = seat_BLL.GetSeatReserved(screen_id);
            if (n > 0)
            {
                MessageBox.Show("Đã có " + n + " ghế đã đặt!");
                return false;
            }
            return true;
        }

        public bool CanUpdateScreening(int screen_id)
        {
            Screening_DAL dal = new Screening_DAL();
            Seat_BLL seat_BLL = new Seat_BLL();
            if (dal.GetDateTimeScreeningInfor(screen_id) <= DateTime.Now.AddMinutes(30))
            {
                MessageBox.Show("Không thể cập nhật");
                return false;
            }

            int n = seat_BLL.GetSeatReserved(screen_id);
            if (n > 0)
            {
                MessageBox.Show("Đã có " + n + " ghế đã đặt!");
                return false;
            }
            return true;
        }
        public List<ScreeningInfor> GetScreeningInforsFilter(DateTime dateTime)
        {
            Screening_DAL dal = new Screening_DAL();
            List<ScreeningInfor> list = new List<ScreeningInfor>();
            foreach (ScreeningInfor s in dal.GetScreeningInforsFilter(dateTime))
            {
                if (s.ShowDay + s.ShowTime >= DateTime.Now.AddMinutes(30))
                {
                    list.Add(s);
                }
            }
            return list;
        }
    }
}
