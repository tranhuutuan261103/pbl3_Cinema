using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View
{
    public partial class Form_SignUp : Form
    {
        public delegate void HaveEvent(object sender, EventArgs e);
        public HaveEvent haveEvent { set; get; }
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            haveEvent(sender, e);
        }
    }
}
