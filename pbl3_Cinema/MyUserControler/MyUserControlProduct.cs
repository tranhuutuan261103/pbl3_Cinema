using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3_Cinema.MyUserControler;
using pbl3_Cinema.View.AdminView.ManageProduct;

namespace pbl3_Cinema.MyUserControler
{
    public partial class MyUserControlProduct : UserControl
    {

        #region Getter & Setter for Label and PictureBox
        private string _nameProduct;
        private string _soluong;
        private Image _icon;
        private string _price;
        private int _id;

        [Category("Custom props")]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom props")]
        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; lblName.Text = value; }
        }

        [Category("Custom props")]
        public string SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        [Category("Custom props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }
        #endregion


        public MyUserControlProduct()
        {
            InitializeComponent();
        }

        private void MyUserControlProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 215, 0);
        }

        private void MyUserControlProduct_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 215, 0);
        }

        private void MyUserControlProduct_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 221, 130);
        }

        
    }
}
