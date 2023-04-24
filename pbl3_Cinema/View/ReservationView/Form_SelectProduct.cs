using pbl3_Cinema.BLL;
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
    public partial class Form_SelectProduct : Form
    {
        public Form_SelectProduct()
        {
            InitializeComponent();
        }

        private void Form_SelectProduct_Load(object sender, EventArgs e)
        {

            Product_BLL bll = new Product_BLL();
            List<product> listProduct = bll.GetListProduct();

            flowLayoutPanel_SelectProduct.Controls.Clear();
            foreach (product product in listProduct)
            {
                MyUserControlProduct myUCProduct = new MyUserControlProduct();
                myUCProduct.NameProduct = product.name_product;
                myUCProduct.Price = Convert.ToString(product.price);
                myUCProduct.ID = product.id;
                myUCProduct.Icon = MyFuncStatic.MyConvert.ConvertBinaryToImage(product.image_product);
                myUCProduct.SoLuong = product.the_number_of_products.ToString();
                Panel panel = new Panel()
                {
                    Width = flowLayoutPanel_SelectProduct.Width - 30,
                    Height = myUCProduct.Height,
                };
                panel.Controls.Add(new MyUserControlButtonSelectNumber() { Dock = DockStyle.Right});
                myUCProduct.Dock = DockStyle.Left;
                panel.Controls.Add(myUCProduct);
                flowLayoutPanel_SelectProduct.Controls.Add(panel);
            }
        }

        public List<product> GetInforSelectedProduct()
        {
            List<product> products = new List<product>();
            foreach (Panel panel in flowLayoutPanel_SelectProduct.Controls)
            {
                MyUserControlButtonSelectNumber b = (MyUserControlButtonSelectNumber)panel.Controls[0];
                if (b.Number != 0)
                {
                    MyUserControlProduct p = (MyUserControlProduct)panel.Controls[1];
                    product product = new product { id = p.ID, the_number_of_products = b.Number };
                    products.Add(product);
                }
            }
            return products;
        }
    }
}
