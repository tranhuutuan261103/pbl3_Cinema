using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;
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
            LoadRating();
            RTB_TextChanged();
            CommentChanged();
            LoadComment();
        }

        private void LoadRating()
        {
            Rating_BLL bll = new Rating_BLL();
            label_Rate.Text = bll.GetPointRating(id_movie).ToString() + "/10 (" + bll.GetRatingCountByIdMovie(id_movie)
                + " đánh giá)";
        }

        private void RTB_TextChanged()
        {
            richTextBox_Description.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox_Description.Height = (richTextBox_Description.GetLineFromCharIndex(richTextBox_Description.Text.Length) + 1) *
                        richTextBox_Description.Font.Height + 1 + richTextBox_Description.Margin.Vertical;
        }

        private void CommentChanged()
        {
            label_content.Location = new Point(label_content.Location.X, richTextBox_Description.Location.Y + richTextBox_Description.Size.Height + 20);
            panel_Comment.Location = new Point(panel_Comment.Location.X, label_content.Location.Y + label_content.Size.Height + 20);
        }

        private void LoadComment()
        {
            MyUserControlComment uc = new MyUserControlComment();
            uc.Location = new Point(10, 0);
            uc.clicked += new EventHandler(clickedComment);
            panel_Comment.Controls.Add(uc);
            uc.Show();

            // load list comment
            LoadDetailComment();
        }

        private void LoadDetailComment()
        {
            flowLayoutPanel1.Controls.Clear();
            Rating_BLL bll = new Rating_BLL();
            List<rating> list = bll.GetAllRatingsByIdMovie(id_movie);
            foreach(rating item in list)
            {
                MyUserControlInforComment uc = new MyUserControlInforComment();
                uc.r = item;
                flowLayoutPanel1.Controls.Add(uc);
                uc.Show();
            }
        }

        private void clickedComment(object sender, EventArgs e)
        {
            rating r = (rating)sender;
            r.movie_id = id_movie;
            r.customer_id = Account;
            Rating_BLL bll = new Rating_BLL();
            if (bll.AddRating(r) == 0)
            {
                MessageBox.Show("Bạn đã đánh giá bài viết này rồi");
            }
            else
            {
                LoadRating();
                LoadDetailComment();
            }
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            Form_SelectScreening form = new Form_SelectScreening();
            form.Account = Account;
            form.SetSelectedCBBMovie(id_movie);
            form.ShowDialog();
        }

        private void Form_DetailInforFilm_Load(object sender, EventArgs e)
        {

        }

        public void SetVisitabe(bool v)
        {
            btn_Reservation.Visible = v;
            label_content.Visible = v;
            panel_Comment.Visible = v;
        }
    }
}
