using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.View.ReservationView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.DetailInforFilm
{
    public partial class Form_DetailInforFilm : Form
    {
        public string Account { set; get; }
        public int  id_movie { set; get; }
        public Form_DetailInforFilm()
        {
            InitializeComponent();
        }

        public void SetInforMovie(int id_movie)
        {
            Cinema_BLL bll = new Cinema_BLL();
            pictureBox_Poster.Image = bll.GetPosterById(id_movie);
            MyMovieInfor movieInfor = bll.GetMovieById(id_movie);
            label_Title.Text = movieInfor.Title;
            label_Category.Text = movieInfor.Category.name_Category;
            label_Cast.Text = movieInfor.ListCast;
            label_Director.Text = movieInfor.Director;
            label_Duration.Text = movieInfor.Duration_min + " phút";
            label_Release_date.Text = movieInfor.Release_date.ToString("dd/MM/yyyy");
            richTextBox_Description.Text = movieInfor.Description;
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            Form_SelectScreening form = new Form_SelectScreening();
            form.Account = Account;
            form.SetSelectedCBBMovie(id_movie);
            form.ShowDialog();
        }
    }
}
