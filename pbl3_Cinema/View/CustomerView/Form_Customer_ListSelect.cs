using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView
{
    public partial class Form_Customer_ListSelect : Form
    {
        public delegate void MySelect(object sender, EventArgs e);
        public MySelect mySelect { get; set; }
        public Form_Customer_ListSelect()
        {
            InitializeComponent();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            mySelect(sender, e);
        }
    }
}
