using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace pbl3_Cinema.View.AdminView
{
    public partial class Form_Admin_ListSelect : Form
    {
        public delegate void MySelect(object sender, EventArgs e);
        public MySelect mySelect {  get; set; }
        public Form_Admin_ListSelect()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            mySelect(sender, e);
        }

        private void bnt_5_Click(object sender, EventArgs e)
        {

        }
    }
}
