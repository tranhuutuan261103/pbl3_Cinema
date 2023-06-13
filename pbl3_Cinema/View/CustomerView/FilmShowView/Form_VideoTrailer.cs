using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.CustomerView.FilmShowView
{
    public partial class Form_VideoTrailer : Form
    {
        public string videoPath { set; get; }
        public Form_VideoTrailer()
        {
            InitializeComponent();
        }

        private void Form_VideoTrailer_Load(object sender, EventArgs e)
        {
            string html = @"<html><head>
                            <meta http-equiv='X-UA-Compatible' content='IE=Edge'/>
                            </head><body>
                            <iframe width='560' height='315' src='https://www.youtube.com/embed/{0}' frameborder='0' allowfullscreen></iframe>
                            </body></html>";
            try
            {
                webVideo.DocumentText = string.Format(html, videoPath.Split('=')[1]);
            }
            catch (Exception)
            {
                MessageBox.Show("Video không tồn tại");
                Dispose();
            }
        }
    }
}
