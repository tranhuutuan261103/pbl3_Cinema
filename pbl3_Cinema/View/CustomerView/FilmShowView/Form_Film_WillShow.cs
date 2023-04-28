using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyUserControler;
using pbl3_Cinema.View.CustomerView.DetailInforFilm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.FilmNowShowView
{
    public partial class Form_Film_WillShow : Form
    {
        public string Account { set; get; }
        public Form_Film_WillShow()
        {
            InitializeComponent();
            myInit();
        }
        public void ShowAllMovieInforUpComing()
        {
            Cinema_BLL bll = new Cinema_BLL();
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            CBB_Category cbb = cbb_Category.SelectedItem as CBB_Category;
            list = bll.GetAllMovieInforUpComing(cbb.id);
            flowLayoutPanel.Visible = false;
            flowLayoutPanel.Controls.Clear();
            if (list.Count > 0)
            {
                foreach (MyMovieInfor movie in list)
                {
                    UserControlDisplayMovie ucdm = new UserControlDisplayMovie()
                    {
                        id = movie.Id,
                        titleFilm = movie.Title,
                        image = bll.GetPosterById(movie.Id),
                    };
                    ucdm.ClickMovie += new EventHandler(ClickMovie);
                    flowLayoutPanel.Controls.Add(ucdm);
                }
            }
            flowLayoutPanel.Visible = true;
        }

        public void myInit()
        {
            Cinema_BLL bll = new Cinema_BLL();
            List<CBB_Category> listCategory = new List<CBB_Category>()
            {
                new CBB_Category()
                {
                    id = 0,
                    name_Category = "Tất cả"
                }
            };
            listCategory.AddRange(bll.GetAllCBBCategory());
            cbb_Category.Items.AddRange(listCategory.ToArray());
            cbb_Category.SelectedIndex = 0;
        }

        public void ClickMovie(object sender, EventArgs e)
        {
            UserControlDisplayMovie u = (UserControlDisplayMovie)sender;
            flowLayoutPanel.Dispose();
            panel.Dispose();
            Form_DetailInforFilm form = new Form_DetailInforFilm();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Account = Account;
            form.id_movie = u.id;
            form.SetInforMovie(u.id);
            this.Controls.Add(form);
            form.Show();
        }

        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllMovieInforUpComing();
        }
    }
}
