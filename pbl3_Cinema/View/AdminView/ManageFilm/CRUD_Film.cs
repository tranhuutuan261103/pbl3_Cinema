﻿using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.MyFuncStatic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.ManageFilm
{
    public partial class CRUD_Film : Form
    {
        int id;
        private Image img;
        private string videoPath;
        public delegate void MyDel(object o);
        public MyDel d { set; get; }
        public CRUD_Film()
        {
            InitializeComponent();
            myInit();
        }

        public void myInit()
        {
            Cinema_BLL bll = new Cinema_BLL();
            cbb_Category.Items.AddRange(bll.GetAllCBBCategory().ToArray());
        }

        private void btn_Attach_Poster_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG|*.jpg;*.png;*.jpeg";
            ofd.ValidateNames = true;
            ofd.Multiselect = false;
            using (ofd)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_Oke_Click(object sender, EventArgs e)
        {
            movie movie = new movie();
            movie.id = id;
            movie.title = textBox_Title.Text;
            movie.category_id= ((CBB_Category)cbb_Category.SelectedItem).id;
            movie.description_movie = richTextBox_Description.Text;
            movie.director = textBox_Director.Text;
            movie.list_cast = textBox_List_cast.Text;
            try
            {
                movie.duration_min = Convert.ToInt32(textBox_Duration_Min.Text);
            }
            catch
            {
                MessageBox.Show("Thời lượng phim là một số nguyên dương");
                return;
            }
            if (movie.duration_min <=0)
            {
                MessageBox.Show("Thời lượng phim là một số nguyên dương");
                return;
            }
            movie.release_date = dateTimePicker_StartDay.Value;
            movie.expiration_date = dateTimePicker_EndDay.Value;

            if (movie.release_date > movie.expiration_date)
            {
                MessageBox.Show("Ngày release phim không thể trễ hơn ngày hết hạn");
                return;
            }

            if (img!=null)
            {
                movie.poster = MyFuncStatic.MyConvert.ConvertImageToBinary(img);
            }

            videoPath = textVideoLink.Text;
            if (videoPath!=null)
            {
                movie.video_trailer = videoPath;
            }
            d(movie);
            Dispose();
        }

        public void fillValue(int id)
        {
            this.id = id;
            Cinema_BLL bll = new Cinema_BLL();
            MyMovieInfor Movie = bll.GetMovieById(id);
            if (Movie != null)
            {
                textBox_Title.Text = Movie.Title;
                textBox_Duration_Min.Text = Movie.Duration_min.ToString();
                textBox_Director.Text = Movie.Director;
                textBox_List_cast.Text = Movie.ListCast;
                richTextBox_Description.Text = Movie.Description;
                for (int i = 0; i<cbb_Category.Items.Count; i++)
                {
                    CBB_Category cbb = cbb_Category.Items[i] as CBB_Category;
                    if (cbb.id == Movie.Category.id) 
                    {
                        cbb_Category.SelectedIndex = i;
                    }
                }
                dateTimePicker_StartDay.Value = Movie.Release_date;
                dateTimePicker_EndDay.Value = Movie.Expiration_date;
                textVideoLink.Text = Movie.Video_trailer;
            }
        }

        private void dateTimePicker_StartDay_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker_EndDay.Value < dateTimePicker_StartDay.Value)
            {
                dateTimePicker_EndDay.Value = dateTimePicker_StartDay.Value;
            }
        }

        private void dateTimePicker_EndDay_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_EndDay.Value < dateTimePicker_StartDay.Value)
            {
                dateTimePicker_StartDay.Value = dateTimePicker_EndDay.Value;
            }
        }
    }
}
