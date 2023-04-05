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
using pbl3_Cinema.MyUserControler;
using pbl3_Cinema.BLL;

namespace pbl3_Cinema.View.CustomerView.FilmNowShowView
{
    public partial class Form_Film_NowShow : Form
    {
        public Form_Film_NowShow()
        {
            InitializeComponent();
            myInit();
        }
        public void myInit()
        {
            Cinema_BLL bll = new Cinema_BLL();
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            list = bll.GetAllMovieInforValidDay();
            if (list.Count > 0 )
            {
                foreach( MyMovieInfor movie in list )
                {
                    flowLayoutPanel.Controls.Add(new UserControlDisplayMovie
                    {
                        id = movie.Id,
                        titleFilm = movie.Title,
                        image = bll.GetPosterById(movie.Id)
                    });
                }
            }
        }
    }
}
