using Guna.UI2.WinForms;
using pbl3_Cinema.BLL;
using pbl3_Cinema.MyFuncStatic;
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

namespace pbl3_Cinema.View.AdminView.ManageProduct
{
    public partial class Manage_Product : Form
    {
        public Manage_Product()
        {
            InitializeComponent();
        }

        public void GenerateDynamicUserControl()
        {
            Product_BLL objBLL = new Product_BLL();

            List<product> listProduct = objBLL.GetListProduct();
            flowLayoutPanel1.Controls.Clear();
            foreach (product p in listProduct)
            {
                MyUserControlProduct aProductItem = new MyUserControlProduct();
                aProductItem.Width = flowLayoutPanel1.Width - 10;
                aProductItem.NameProduct = p.name_product;
                aProductItem.Price = p.price.ToString();
                aProductItem.Icon = MyConvert.ConvertBinaryToImage(p.image_product);
                aProductItem.SoLuong = p.the_number_of_products.ToString();
                aProductItem.ID = p.id;
                aProductItem.Click += AProductItem_Click;
                this.flowLayoutPanel1.Controls.Add(aProductItem);
            }
        }

        private void AProductItem_Click(object sender, EventArgs e)
        {
            MyUserControlProduct p = (MyUserControlProduct)sender;
            this.pictureBox1.Image = p.Icon;
            this.lblName.Text = p.NameProduct;
            this.lblprice.Text = p.Price.ToString();
            this.lblQuantity.Text = p.SoLuong;
            this.lblID.Text = p.ID.ToString();
            this.panelInfor.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.panelInfor.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manage_Product_Load(object sender, EventArgs e)
        {
            this.panelInfor.Visible = false;
            GenerateDynamicUserControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CRUD_Product form = new CRUD_Product();
            form.Text = "Edit";
            form.pHash = this.lblID.Text;
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận muốn xóa?","Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                CinemaEntities db = new CinemaEntities();
                int hash = Convert.ToInt32(lblID.Text);
                var product = db.products.Find(hash);
                db.products.Remove(product);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công sản phẩm");
            }   
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CRUD_Product form = new CRUD_Product();
            form.Text = "Add";
            form.pHash = "";
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}
