using pbl3_Cinema.BLL;
using pbl3_Cinema.MyUserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
                MyUserControlSelectProduct myUCProduct = new MyUserControlSelectProduct();
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
                myUCProduct.Dock = DockStyle.Left;
                panel.Controls.Add(myUCProduct);
                flowLayoutPanel_SelectProduct.Controls.Add(panel);
            }
        }

        public List<detail_bill> GetInforSelectedProduct()
        {
            List<detail_bill> products = new List<detail_bill>();
            Product_BLL bll = new Product_BLL();
            foreach (Panel panel in flowLayoutPanel_SelectProduct.Controls)
            {
                MyUserControlSelectProduct p = (MyUserControlSelectProduct)panel.Controls[0];
                if (p.GetSoLuong() > 0)
                {
                    detail_bill product = new detail_bill
                    {
                        product_id = p.ID,
                        the_number_of_products = p.GetSoLuong(),
                        price = bll.GetPriceProduct(p.ID),
                    };
                    products.Add(product);
                }
            }
            return products;
        }
    }
}
