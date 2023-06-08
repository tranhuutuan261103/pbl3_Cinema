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
using pbl3_Cinema.View.AdminView.ManageScreen;
using pbl3_Cinema.View.CustomerView.FilmNowShowView;
using pbl3_Cinema.View.CustomerView.ManageAccount;
using pbl3_Cinema.View.AdminView.ManageProduct;
using pbl3_Cinema.View.AdminView.MaganeInfor;
using pbl3_Cinema.View.AdminView.ManageStaff;
using pbl3_Cinema.View.StaffView;
using pbl3_Cinema.View.CustomerView.ManageInfor;
using pbl3_Cinema.View.CustomerView.ManageBooking;
using pbl3_Cinema.View.AdminView.ManageAccount;
using pbl3_Cinema.View.AdminView.Statistic;

namespace pbl3_Cinema.View
{
    public partial class MainForm : Form
    {
        public string account { set; get; }
        Form activeDisplay;
        Form activeListSelect;
        Guna2Button currentButton;
        public MainForm()
        {
            InitializeComponent();
        }

        public void SignOut()
        {
            this.Close();
        }

        private void OpenListSelect(Form childListSelect)
        {
            if (activeListSelect != null)
            {
                activeListSelect.Close();
            }
            activeListSelect = childListSelect;
            childListSelect.TopLevel = false;
            childListSelect.Dock = DockStyle.Top;
            panel_SubListSelect.Controls.Add(activeListSelect);
            childListSelect.Show();
        }

        public void Authorization(object o, int role)
        {
            if (role == 0)
            {
                Form_Customer_ListSelect childListSelect = new Form_Customer_ListSelect();
                childListSelect.mySelect += new Form_Customer_ListSelect.MySelect(ChangeDisplayCustomer);
                OpenListSelect(childListSelect);
            }

            if (role == 1)
            {
                Form_Staff_ListSelect childListSelect = new Form_Staff_ListSelect();
                childListSelect.mySelect += new Form_Staff_ListSelect.MySelect(ChangeDisplayStaff);
                OpenListSelect(childListSelect);
            }

            if (role == 2)
            {
                Form_Admin_ListSelect childListSelect = new Form_Admin_ListSelect();
                childListSelect.mySelect += new Form_Admin_ListSelect.MySelect(ChangeDisplayAdmin);
                OpenListSelect(childListSelect);
            }
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentButton != (Guna2Button)senderBtn)
                {
                    DisableButton();
                    currentButton = (Guna2Button)senderBtn;
                    currentButton.FillColor = Color.FromArgb(200, 185, 255);
                    currentButton.ForeColor = Color.Black;
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in activeListSelect.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    ((Guna2Button)previousBtn).FillColor = Color.FromArgb(94, 148, 255);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeDisplay != null)
            {
                activeDisplay.Close();
            }
            ActiveButton(btnSender);
            activeDisplay = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel_Display.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void ChangeDisplayAdmin(object sender,  EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn != null)
            {
                if (btn.Text == "Quản lý phim")
                {
                    OpenChildForm(new Form_ManageFilm(), sender);
                }

                if (btn.Text == "Quản lý phòng chiếu")
                {
                    OpenChildForm(new Form_ManageAuditorium(), sender);
                }

                if (btn.Text == "Quản lý đồ ăn")
                {
                    OpenChildForm(new Manage_Product(), sender);
                }

                if (btn.Text == "Quản lý suất chiếu")
                {
                    OpenChildForm(new Form_ManageScreening(), sender);
                }

                if (btn.Text == "Quản lý vé")
                {
                    OpenChildForm(new Form_ManageReservation(), sender);
                }

                if (btn.Text == "Doanh thu")
                {
                    OpenChildForm(new Form_Revenue(), sender);
                }

                if(btn.Text == "Thông tin tài khoản")
                {
                    Form_Infor_Admin form = new Form_Infor_Admin()
                    {
                        Account = account,
                    };
                    OpenChildForm(form, sender);
                }   
                
                if(btn.Text == "Quản lý nhân viên")
                {
                    OpenChildForm(new Form_Manage_Staff(), sender);
                }

                if (btn.Text == "Quản lý khách hàng")
                {
                    OpenChildForm(new Form_ManageAccount(), sender);
                }
            }
        }

        private void ChangeDisplayStaff(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn != null)
            {
                if (btn.Text == "Phim đang chiếu")
                {
                    Form_Film_NowShow form = new Form_Film_NowShow()
                    {
                        Account = account,
                    };
                    OpenChildForm(form, sender);
                }

                if (btn.Text == "Phim sắp chiếu")
                {
                    Form_Film_WillShow form = new Form_Film_WillShow();
                    OpenChildForm(form, sender);
                }

                if (btn.Text == "Lịch sử đặt vé")
                {
                    Form_ManageBooking form = new Form_ManageBooking()
                    {
                        Account = account
                    };
                    OpenChildForm(form, sender);
                }

                if (btn.Text == "Quản lý tài khoản")
                {
                    Form_Staff_Infor form = new Form_Staff_Infor()
                    {
                        Account = account,
                    };
                    OpenChildForm(form, sender);
                }

                if (btn.Text == "Quản lý khách hàng")
                {
                    OpenChildForm(new Form_ManageAccount(), sender);
                }

                if (btn.Text == "Quản lý vé")
                {
                    OpenChildForm(new Form_ManageReservation(), sender);
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
                    Form_Film_NowShow form = new Form_Film_NowShow()
                    {
                        Account = account,
                    };
                    OpenChildForm(form, sender);
                }

                if (btn.Text == "Phim sắp chiếu")
                {
                    Form_Film_WillShow form = new Form_Film_WillShow();
                    OpenChildForm(form, sender);
                }

                if (btn.Text == "Lịch sử đặt vé")
                {
                    Form_ManageBooking form = new Form_ManageBooking()
                    {
                        Account = account
                    };
                    OpenChildForm(form, sender);
                }

                if (btn.Text == "Quản lý tài khoản")
                {
                    FormAccountCustomerManage form = new FormAccountCustomerManage()
                    {
                        Account = account,
                    };
                    form.signOut = new FormAccountCustomerManage.SignOut(SignOut);
                    OpenChildForm(form, sender);
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng suất không?", "Log out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
