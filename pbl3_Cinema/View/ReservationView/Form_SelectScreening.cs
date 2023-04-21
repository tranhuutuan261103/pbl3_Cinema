using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.ReservationView
{
    public partial class Form_SelectScreening : Form
    {
        public Form_SelectScreening()
        {
            InitializeComponent();
            daySelected = DateTime.Now;
            myInitCBBMovie();
            myInitCBBDayShow();
        }

        public string Account { set; get; }

        private DateTime daySelected;

        private void myInitCBBMovie()
        {
            Cinema_BLL bll = new Cinema_BLL();
            List<CBBMovie> cBBMovies = new List<CBBMovie>()
            {
                new CBBMovie
                {
                    id_movie = 0,
                    title = "Tất cả"
                }
            };

            cBBMovies.AddRange(bll.GetCBBMoviesNow());

            cbb_SelectMovie.Items.AddRange(cBBMovies.ToArray());
            
        }

        private void myInitCBBDayShow()
        {
            MyUserControlSelectDay[] list = new MyUserControlSelectDay[7];
            for (int i = 0;i< list.Length; i++)
            {
                list[i] = new MyUserControlSelectDay()
                {
                    myDateTime = DateTime.Now.AddDays(i),
                };
                if (i != list.Length - 1 )
                {
                    list[i].Margin = new Padding(3, 2, 12 ,2);
                }
                list[i].clickDay += new EventHandler(GetShowDay);
                flowLayoutPanel_SelectDayShow.Controls.Add(list[i]);
                list[i].Show();
            }
            list[0].button_Clicked();
        }

        public void SetSelectedCBBMovie(int id_movie)
        {
            foreach (CBBMovie item in cbb_SelectMovie.Items)
            {
                if (item.id_movie == id_movie)
                {
                    cbb_SelectMovie.SelectedItem = item;
                    return;
                }
            }
        }

        private void GetShowDay(object sender, EventArgs e)
        {
            MyUserControlSelectDay m = (MyUserControlSelectDay)sender;
            foreach (MyUserControlSelectDay item in flowLayoutPanel_SelectDayShow.Controls)
            {
                item.SetNotSelectedShowDay();
            }
            m.SetSelectedShowDay();
            daySelected = m.myDateTime;
            if (cbb_SelectMovie.SelectedIndex == -1)
            {
                cbb_SelectMovie.SelectedIndex = 0;
            }
            ShowListScreeningByFilter();
        }

        private void ShowListScreeningByFilter()
        {
            if (cbb_SelectMovie.SelectedIndex >= 0)
            {
                CBBMovie c = cbb_SelectMovie.SelectedItem as CBBMovie;
                if (c.id_movie != 0)
                {
                    flowLayoutPanel_DisplayScreening.Controls.Clear();
                    MyUserControlSelectScreening m = new MyUserControlSelectScreening();
                    m.id_movie = c.id_movie;
                    m.nameMovie = c.title;
                    m.dayShow = daySelected;
                    m.clickedScreening += new EventHandler(clicked_screening);
                    flowLayoutPanel_DisplayScreening.Controls.Add(m);
                    m.Show();
                }
                else if (c.id_movie == 0)
                {
                    flowLayoutPanel_DisplayScreening.Controls.Clear();
                    foreach (CBBMovie movie in cbb_SelectMovie.Items)
                    {
                        if (movie.id_movie != 0)
                        {
                            MyUserControlSelectScreening m = new MyUserControlSelectScreening();
                            m.id_movie = movie.id_movie;
                            m.nameMovie = movie.title;
                            m.dayShow = daySelected;
                            m.clickedScreening += new EventHandler(clicked_screening);
                            flowLayoutPanel_DisplayScreening.Controls.Add(m);
                            m.Show();
                        }
                    }
                }
            }
        }

        private void clicked_screening(object sender, EventArgs e)
        {
            ScreeningInfor m = (ScreeningInfor)sender;
            int id_screening = m.id;
            Form_Reservation form = new Form_Reservation();
            form.id_screening = id_screening;
            form.Account = Account;
            form.ShowDialog();
        }

        private void cbb_SelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowListScreeningByFilter();
        }
    }
}
