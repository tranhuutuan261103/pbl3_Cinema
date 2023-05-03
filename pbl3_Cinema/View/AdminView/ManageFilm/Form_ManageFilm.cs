using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using pbl3_Cinema.View.AdminView.ManageFilm;

namespace pbl3_Cinema.View.AdminView
{
    public partial class Form_ManageFilm : Form
    {
        public Form_ManageFilm()
        {
            InitializeComponent();
            LoadMovie();
        }
        public void LoadMovie()
        {
            Cinema_BLL bll = new Cinema_BLL();
            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[]
            //{
            //    new DataColumn() {ColumnName = "id", DataType = typeof(int)},
            //    new DataColumn() {ColumnName = "title", DataType = typeof(string)},
            //    new DataColumn() {ColumnName = "category", DataType = typeof(string)},
            //    new DataColumn() {ColumnName = "duration_min", DataType = typeof(int)},
            //    new DataColumn() {ColumnName = "release_date", DataType=typeof(DateTime)},
            //    new DataColumn() {ColumnName = "expiration_date", DataType= typeof(DateTime)},
            //});
                
            //foreach (movie Movie in bll.GetAllMovie())
            //{
            //    dt.Rows.Add(Movie.id, Movie.title, Movie.category.name_category, Movie.duration_min, Movie.release_date, Movie.expiration_date);
            //}
            //dataGridView_ListFilm.DataSource = dt;
            //dataGridView_ListFilm.Columns["id"].Visible = false;
            //dataGridView_ListFilm.Columns["title"].HeaderText = "Tên phim";

            dataGridView_ListFilm.DataSource = bll.GetAllMovieInfor().ToArray();
        }

        private void AddFilm(object o)
        {
            movie Movie = (movie)o;
            Cinema_BLL bll = new Cinema_BLL();
            bll.AddFilm(Movie);
            LoadMovie();
        }

        private void btn_AddFilm_Click(object sender, EventArgs e)
        {
            CRUD_Film form = new CRUD_Film();
            form.d += new CRUD_Film.MyDel(AddFilm);
            form.ShowDialog();
        }

        private void UpdateFilm(object o)
        {
            movie Movie = (movie)o;
            Cinema_BLL bll = new Cinema_BLL();
            bll.UpdateFilm(Movie);
            LoadMovie();
        }

        private void btn_UpdateFilm_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListFilm.SelectedRows.Count == 0)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridView_ListFilm.SelectedRows[0].Cells["id"].Value);
            CRUD_Film form = new CRUD_Film();
            form.fillValue(id);
            form.d += new CRUD_Film.MyDel(UpdateFilm);
            form.ShowDialog();
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            Cinema_BLL bll = new Cinema_BLL();
            category c = new category();
            c.name_category = textBox1.Text;
            if (bll.AddCategory(c) == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {

            }
        }
    }
}
