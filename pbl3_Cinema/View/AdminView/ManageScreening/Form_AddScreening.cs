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
            cbb_Auditorium.Items.AddRange(bll.GetAllCBBAuditorimActive().ToArray());
            cbb_Movie.Items.AddRange(bll.GetCBBMoviesNow().ToArray());

            textBox_Price.Text = "50000";
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
                auditorium_id = audi_id,
                movie_id = movie_id,
                price = price,
                show_day = showDay,
                show_time = showTime,
            };

            Cinema_BLL bll = new Cinema_BLL();

            //bll.AddScreening(screen);

            DateTime dStar = showDay + showTime;
            DateTime dEnd = showDay + showTime + new TimeSpan(0, bll.GetDurationOfMovie(movie_id), 0);
            
            if (dStar < DateTime.Now.AddMinutes(60))
            {
                MessageBox.Show("Không thể thêm vào lúc này");
                return;
            }

            if (bll.CanAddScreening(dStar, dEnd, audi_id) == false)
            {
                MessageBox.Show("Bị trùng suất chiếu");
                return;
            }
            else
            {
                if (bll.AddScreening(screen) == 1)
                {
                    MessageBox.Show("Thêm suất chiếu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm suất chiếu thất bại");
                    return;
                }
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
