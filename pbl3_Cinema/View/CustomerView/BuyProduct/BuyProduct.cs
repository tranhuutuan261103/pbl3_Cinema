using pbl3_Cinema.BLL;
using pbl3_Cinema.MyFuncStatic;
using pbl3_Cinema.MyUserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.BuyProduct
{
    public partial class BuyProduct : Form
    {
        public BuyProduct()
        {
            InitializeComponent();
        }

        public void GenerateDynamicUserControl()
        {
            Product_BLL objBLL = new Product_BLL();

            List<product> listProduct = objBLL.GetListProduct();
            flowLayoutPanelProduct.Controls.Clear();
            foreach (product p in listProduct)
            {
                MyUserControlProduct aProductItem = new MyUserControlProduct();
                aProductItem.NameProduct = p.name_product;
                aProductItem.Price = p.price.ToString();
                aProductItem.Icon = MyConvert.ConvertBinaryToImage(p.image_product);
                aProductItem.Click += AProductItem_Click;
                flowLayoutPanelProduct.Controls.Add(aProductItem);
            }
        }

        private void AProductItem_Click(object sender, EventArgs e)
        {
            MyUserControlProduct p = (MyUserControlProduct)sender;
            if(p.NameProduct == "Hambuger")
            {
                int temp = Convert.ToInt32(lblHambuger.Text);
                temp++;
                lblHambuger.Text = temp.ToString();
            }
        }

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
