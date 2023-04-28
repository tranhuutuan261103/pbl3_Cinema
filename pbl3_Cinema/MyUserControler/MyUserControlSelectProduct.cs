using pbl3_Cinema.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.MyUserControler
{
    public partial class MyUserControlSelectProduct : MyUserControlProduct
    {
        public MyUserControlSelectProduct()
        {
            InitializeComponent();
            label_Number.Text = SoLuong;
        }

        public int GetSoLuong()
        {
            return Convert.ToInt32(label_SelectedNumber.Text);
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(label_SelectedNumber.Text);
            Product_BLL bll = new Product_BLL();
            if (sl >= bll.GetNumberProduct(ID))
            {
                MessageBox.Show("Hết hàng");
                return;
            }
            sl++;
            label_SelectedNumber.Text = sl.ToString();
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(label_SelectedNumber.Text);
            if (sl <= 0)
            {
                return;
            }
            sl--;
            label_SelectedNumber.Text = sl.ToString();
        }
    }
}
