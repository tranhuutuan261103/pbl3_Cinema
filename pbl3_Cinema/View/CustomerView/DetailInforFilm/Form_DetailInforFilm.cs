using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.DetailInforFilm
{
    public partial class Form_DetailInforFilm : Form
    {
        public string Account { set; get; }
        public int  id_movie { set; get; }
        public Form_DetailInforFilm()
        {
            InitializeComponent();
            label1.Text = Account + id_movie.ToString();
        }
    }
}
