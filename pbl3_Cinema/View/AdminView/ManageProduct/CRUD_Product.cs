using pbl3_Cinema.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3_Cinema.MyFuncStatic;
namespace pbl3_Cinema.View.AdminView.ManageProduct
{
    public partial class CRUD_Product : Form
    {
        public string pHash { get; set; } 
        public CRUD_Product()
        {
            InitializeComponent();
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pic_product.Image = img;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CinemaEntities db = new CinemaEntities();
            byte[] msToArray = MyConvert.ConvertImageToBinary(pic_product.Image);
            string name_product = txtTenMonAn.Text.Trim();
            string donViTinh = txtDonViTinh.Text.Trim();

            int gia;
            int soLuong;
            try
            {
                gia = Convert.ToInt32(txtGia.Text);
                soLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Sai định dạng");
                return;
            }

            if (gia <= 0 || soLuong <= 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
                return;
            }

            product p = new product()
            {
                image_product = msToArray,
                name_product = name_product,
                unit = donViTinh,
                price = gia,
                the_number_of_products = soLuong
            };

            Product_BLL productBLL = new Product_BLL();
            if(this.Text == "Add")
            {
                if (productBLL.AddProduct(p))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý");
                    this.Dispose();
                }
            }
            else
            {
                int hash = Convert.ToInt32(this.pHash);
                
                var pTemp = db.products.Find(hash);
                pTemp.name_product = p.name_product;
                pTemp.unit = p.unit; 
                pTemp.price = p.price;
                pTemp.the_number_of_products = p.the_number_of_products;
                pTemp.image_product = p.image_product;
                if (productBLL.EditProduct(hash, pTemp))
                {
                    MessageBox.Show("Update thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý (update)");
                    this.Dispose();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CRUD_Product_Load(object sender, EventArgs e)
        {
            CinemaEntities db = new CinemaEntities();
            if(this.pHash != "")
            {
                var product = db.products.Find(Convert.ToInt32(pHash));
                this.txtTenMonAn.Text = product.name_product;
                this.txtDonViTinh.Text = product.unit.ToString();
                this.txtGia.Text = product.price.ToString();
                this.txtSoLuong.Text = product.the_number_of_products.ToString();
                this.pic_product.Image = MyConvert.ConvertBinaryToImage(product.image_product);
            }
        }
    }
}
