using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.MyUserControler
{
    public partial class MyUserControlDetailInforBooking : UserControl
    {
        private string _nameProduct;
        public string nameProduct
        {
            set
            {
                _nameProduct = value;
                label_NameProduct.Text = value;
            }
            get { return _nameProduct; }
        }

        private int _price;
        public int price
        {
            set
            {
                _price = value;
                label_Price.Text = _price + "đ";
            }
            get { return _price; }
        }
        public MyUserControlDetailInforBooking()
        {
            InitializeComponent();
        }
    }
}
