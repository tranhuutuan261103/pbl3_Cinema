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
    public partial class UserControlDisplayMovie : UserControl
    {
        public UserControlDisplayMovie()
        {
            InitializeComponent();
            myInit();
        }
        #region Properties
        private int _id;
        private string _titleFilm;
        private Image _image;

        [Category("Custom Props")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Category("Custom Props")]
        public string titleFilm
        {
            get
            {
                return _titleFilm;
            }
            set
            {
                _titleFilm = value;
                label_NameFilm.Text = value;
            }
        }

        [Category("Custom Props")]
        public Image image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                pictureBox_Film.Image = value;
            }
        }
        #endregion

        private void myInit()
        {
            panel_Opacity.BackColor = Color.FromArgb(0, Color.Black);
            var pos = this.PointToScreen(panel_Opacity.Location);
            pos = pictureBox_Film.PointToClient(pos);
            panel_Opacity.Parent = pictureBox_Film;
            panel_Opacity.Location = pos;
            panel_Opacity.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void panel_Opacity_MouseEnter(object sender, EventArgs e)
        {
            panel_Opacity.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel_Opacity_MouseLeave(object sender, EventArgs e)
        {
            panel_Opacity.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void panel_Opacity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id.ToString());
        }
    }
}
