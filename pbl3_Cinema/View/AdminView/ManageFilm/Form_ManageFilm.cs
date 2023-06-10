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
            LoadCBBCategory();
        }

        private void LoadCBBCategory()
        {
            Cinema_BLL bll = new Cinema_BLL();
            List<CBB_Category> list = bll.GetAllCBBCategory();
            CBB_Category c = new CBB_Category()
            {
                id = 0,
                name_Category = "Tất cả",
            };
            cbb_Category.Items.Add(c);
            cbb_Category.Items.AddRange(list.ToArray());
            cbb_Category.SelectedIndex = 0;
        }
        public void LoadMovie()
        {
            if (cbb_Category.SelectedIndex == -1)
            {
                return;
            }
            int id = ((CBB_Category)cbb_Category.SelectedItem).id;
            Cinema_BLL bll = new Cinema_BLL();
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            if (id == 0)
            {
                list = bll.GetAllMovieInfor();
            }
            else
            {
                list = bll.GetAllMovieInfor(id);
            }
            list = list.Where(m => m.Title.ToLower().Contains(text_Search.Text.ToLower())).OrderByDescending(x => x.Release_date).ToList();
            dataGridView_ListFilm.DataSource = list;
            dataGridView_ListFilm.Columns["id"].Visible = false;
            dataGridView_ListFilm.Columns["Title"].Width = 250;
            dataGridView_ListFilm.Columns["Title"].HeaderText = "Tên phim";
            dataGridView_ListFilm.Columns["Category"].HeaderText = "Thể loại";
            dataGridView_ListFilm.Columns["Director"].HeaderText = "Đạo diễn";
            dataGridView_ListFilm.Columns["ListCast"].HeaderText = "Diễn viên";
            dataGridView_ListFilm.Columns["Duration_min"].HeaderText = "Thời lượng";
            dataGridView_ListFilm.Columns["Duration_min"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_ListFilm.Columns["Description"].Visible = false;
            dataGridView_ListFilm.Columns["Release_date"].HeaderText = "Phát hành";
            dataGridView_ListFilm.Columns["Expiration_date"].HeaderText = "Kết thúc";
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            Cinema_BLL bll = new Cinema_BLL();
            category c = new category();
            c.name_category = textBox1.Text;
            if (bll.AddCategory(c) == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMovie();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListFilm.SelectedRows.Count == 0)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridView_ListFilm.SelectedRows[0].Cells["id"].Value);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phim này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cinema_BLL bll = new Cinema_BLL();
                bll.DeleteFilm(id);
                LoadMovie();
            }
        }

        private void text_Search_TextChanged(object sender, EventArgs e)
        {
            LoadMovie();
        }
    }
}
