using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pbl3_Cinema.MyUserControler
{
    public partial class MyUserControlComment : UserControl
    {
        public MyUserControlComment()
        {
            InitializeComponent();
        }


        public EventHandler clicked { set; get; }
        private void btn_Comment_Click(object sender, EventArgs e)
        {
            rating r = new rating()
            {
                point = Convert.ToInt32(label.Text),
                comment = richTextBox.Text,
            };
            clicked(r, e);
        }

        private void ratingStar_ValueChanged(object sender, EventArgs e)
        {
            label.Text = (ratingStar.Value * 2).ToString();
        }
    }
}
