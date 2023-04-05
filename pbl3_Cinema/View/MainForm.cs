using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3_Cinema.View.CustomerView;
using pbl3_Cinema.View.AdminView;
using Guna.UI2.WinForms;
using pbl3_Cinema.View.AdminView.ManageFilm;
using pbl3_Cinema.View.CustomerView.FilmNowShowView;
using pbl3_Cinema.View.CustomerView.ManageAccount;

namespace pbl3_Cinema.View
{
    public partial class MainForm : Form
    {
        public string account { set; get; }
        Form activeDisplay;
        Form activeListSelect;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ControlBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Authorization(object o, int role)
        {
            if (role == 0)
            {
                if (activeListSelect != null)
                {
                    activeListSelect.Close();
                }
                Form_Customer_ListSelect childListSelect = new Form_Customer_ListSelect();
                activeListSelect = childListSelect;
                childListSelect.TopLevel = false;
                childListSelect.Dock = DockStyle.Top;
                childListSelect.mySelect += new Form_Customer_ListSelect.MySelect(ChangeDisplayCustomer);
                panel_SubListSelect.Controls.Add(activeListSelect);
                childListSelect.Show();
            }

            if (role == 2)
            {
                if (activeListSelect != null)
                {
                    activeListSelect.Close();
                }
                Form_Admin_ListSelect childListSelect = new Form_Admin_ListSelect();
                activeListSelect = childListSelect;
                childListSelect.TopLevel = false;
                childListSelect.Dock = DockStyle.Top;
                childListSelect.mySelect += new Form_Admin_ListSelect.MySelect(ChangeDisplayAdmin);
                panel_SubListSelect.Controls.Add(activeListSelect);
                childListSelect.Show();
            }
        }

        private void ChangeDisplayAdmin(object sender,  EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn != null)
            {
                if (btn.Text == "Quản lý phim")
                {
                    if (activeDisplay != null)
                    {
                        activeDisplay.Close();
                    }
                    Form_ManageFilm form_AddFilm = new Form_ManageFilm();
                    activeDisplay = form_AddFilm;
                    form_AddFilm.Dock = DockStyle.Fill;
                    form_AddFilm.TopLevel = false;
                    panel_Display.Controls.Add(form_AddFilm);
                    form_AddFilm.Show();
                }

                if (btn.Text == "Thêm phòng chiếu")
                {
                    if (activeDisplay != null)
                    {
                        activeDisplay.Close();
                    }
                    Form_ManageAuditorium form = new Form_ManageAuditorium();
                    activeDisplay = form;
                    form.Dock = DockStyle.Fill;
                    form.TopLevel = false;
                    panel_Display.Controls.Add(form);
                    form.Show();
                }
            }
        }

        private void ChangeDisplayCustomer(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn != null)
            {
                if (btn.Text == "Phim đang chiếu")
                {
                    if (activeDisplay != null)
                    {
                        activeDisplay.Close();
                    }
                    Form_Film_NowShow form = new Form_Film_NowShow();
                    activeDisplay = form;
                    form.Dock = DockStyle.Fill;
                    form.TopLevel = false;
                    panel_Display.Controls.Add(form);
                    form.Show();
                }

                if (btn.Text == "Phim sắp chiếu")
                {
                    if (activeDisplay != null)
                    {
                        activeDisplay.Close();
                    }
                    Form_Film_WillShow form = new Form_Film_WillShow();
                    activeDisplay = form;
                    form.Dock = DockStyle.Fill;
                    form.TopLevel = false;
                    panel_Display.Controls.Add(form);
                    form.Show();
                }

                if (btn.Text == "Quản lý tài khoản")
                {
                    if (activeDisplay != null)
                    {
                        activeDisplay.Close();
                    }
                    FormAccountCustomerManage form = new FormAccountCustomerManage();
                    activeDisplay = form;
                    form.Dock = DockStyle.Fill;
                    form.TopLevel = false;
                    form.account = account;
                    panel_Display.Controls.Add(form);
                    form.Show();
                }
            }
        }
    }
}
