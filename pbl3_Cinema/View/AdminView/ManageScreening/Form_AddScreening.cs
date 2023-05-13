using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.ManageScreening
{
    public partial class Form_AddScreening : Form
    {
        public int id_screening { set; get; }
        public delegate void CRUDScreening(screening s);
        public CRUDScreening _CRUDScreening { set; get; }
        public Form_AddScreening()
        {
            InitializeComponent();
            myInit();
        }

        private void myInit()
        {
            dateTimePicker_ShowDay.MinDate = DateTime.Now;
            dateTimePicker_ShowDay.MaxDate = DateTime.Now.AddDays(7);

            for(int i = 0;i<24;i++)
            {
                cbb_Hour.Items.Add(i.ToString());
            }
            cbb_Hour.SelectedIndex = 20;

            for(int i = 0;i<60; i+=5)
            {
                cbb_Minute.Items.Add(i.ToString());
            }
            cbb_Minute.SelectedIndex = 0;

            Cinema_BLL bll = new Cinema_BLL();
            Auditorium_BLL auditorium_BLL = new Auditorium_BLL();
            cbb_Auditorium.Items.AddRange(auditorium_BLL.GetAllCBBAuditorimActive().ToArray());
            cbb_Movie.Items.AddRange(bll.GetCBBMoviesNow().ToArray());

            textBox_Price.Text = "50000";

            
        }

        private void Form_AddScreening_Load(object sender, EventArgs e)
        {
            SetInforScreening();
        }

        public void SetTitle(string title)
        {
            label_title.Text = title;
        }
        public void SetInforScreening()
        {
            Screening_BLL bll = new Screening_BLL();
            screening s = bll.GetScreeningById(id_screening);

            if (s != null)
            {
                // day
                try
                {
                    dateTimePicker_ShowDay.Value = s.show_day;
                }
                catch
                {
                    dateTimePicker_ShowDay.Value = dateTimePicker_ShowDay.MinDate;
                }

                textBox_Price.Text = s.price.ToString();
                foreach (CBBMovie item in cbb_Movie.Items)
                {
                    if (item.id_movie == s.movie_id)
                    {
                        cbb_Movie.SelectedItem = item;
                        break;
                    }
                }
                foreach (CBBAuditorium item in cbb_Auditorium.Items)
                {
                    if (item.id == s.auditorium_id)
                    {
                        cbb_Auditorium.SelectedItem = item;
                        break;
                    }
                }

                

                // hour 
                foreach (string item in cbb_Hour.Items)
                {
                    if (Convert.ToInt32(item) == s.show_time.Hours)
                    {
                        cbb_Hour.SelectedItem = item;
                        break;
                    }
                }
                
                // minute
                foreach (string item in cbb_Minute.Items)
                {
                    if (Convert.ToInt32(item) == s.show_time.Minutes)
                    {
                        cbb_Minute.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private bool checkInputInfor()
        {
            if (cbb_Auditorium.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng");
                return false;
            }

            if (cbb_Movie.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim");
                return false;
            }

            return true;
        }

        private void btn_Oke_Click(object sender, EventArgs e)
        {
            if (checkInputInfor() == false)
            {
                return;
            }

            int audi_id = ((CBBAuditorium)cbb_Auditorium.SelectedItem).id;
            int movie_id = ((CBBMovie)cbb_Movie.SelectedItem).id_movie;
            int price = 0;
            int hour = Convert.ToInt32(cbb_Hour.SelectedItem.ToString());
            int minute = Convert.ToInt32(cbb_Minute.SelectedItem.ToString());

            DateTime tempshowDay = dateTimePicker_ShowDay.Value;
            DateTime showDay = new DateTime(tempshowDay.Year, tempshowDay.Month, tempshowDay.Day);
            TimeSpan showTime = new TimeSpan(hour, minute, 0);

            try
            {
                price = Convert.ToInt32(textBox_Price.Text);
            }
            catch 
            {
                MessageBox.Show("Dữ liệu kkhông hợp lệ");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Số tiền phải là số dương");
                return;
            }

            screening screen = new screening
            {
                id = id_screening,
                auditorium_id = audi_id,
                movie_id = movie_id,
                price = price,
                show_day = showDay,
                show_time = showTime,
            };

            Cinema_BLL bll = new Cinema_BLL();

            DateTime dStar = showDay + showTime;
            DateTime dEnd = showDay + showTime + new TimeSpan(0, bll.GetDurationOfMovie(movie_id), 0);
            
            if (dStar < DateTime.Now.AddMinutes(60))
            {
                MessageBox.Show("Không thể thêm vào lúc này");
                return;
            }

            MyMovieInfor m = bll.GetMovieById(movie_id);
            if (m.Release_date > dStar)
            {
                MessageBox.Show("Phim chưa công chiếu\nNgày công chiếu là: " + m.Release_date);
                return;
            }

            Screening_BLL screening_BLL = new Screening_BLL();

            if (screening_BLL.CanAddScreening(dStar, dEnd, audi_id) == false)
            {
                MessageBox.Show("Bị trùng suất chiếu");
                return;
            }
            else
            {
                _CRUDScreening(screen);
            }

            Dispose();
        }

        private void cbb_Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Movie.SelectedIndex != -1)
            {
                Cinema_BLL bll = new Cinema_BLL();
                int movie_id = ((CBBMovie)cbb_Movie.SelectedItem).id_movie;
                int duration = bll.GetDurationOfMovie(movie_id);

                DateTime dayselect = dateTimePicker_ShowDay.Value;
                DateTime daystart = new DateTime(dayselect.Year, dayselect.Month, dayselect.Day);

                int hour = Convert.ToInt32(cbb_Hour.SelectedItem.ToString());
                int minute = Convert.ToInt32(cbb_Minute.SelectedItem.ToString());

                DateTime daytimeend = daystart.AddHours(hour).AddMinutes(minute).AddMinutes(duration);
                

                label_TimeEnd.Text = daytimeend.ToString("MM-dd-yyyy HH:mm:ss"); ;
            }
        }

        
    }
}
