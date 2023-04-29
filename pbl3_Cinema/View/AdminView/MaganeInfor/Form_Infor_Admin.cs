using pbl3_Cinema.BLL;
using pbl3_Cinema.View.SignView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.MaganeInfor
{
    public partial class Form_Infor_Admin : Form
    {
        public string Account { get; set; }
        public user_infor userInfor { get; set; }
        public Form_Infor_Admin()
        {
            InitializeComponent();
        }

        private DateTime _DoB;
        public DateTime DoB
        {
            set
            {
                _DoB = value;
                lblNgaySinh.Text = DoB.Day + "/" + DoB.Month + "/" + DoB.Year;
            }
            get
            {
                return _DoB;
            }
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form_ForgotPassword form = new Form_ForgotPassword();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form_ChangeInfor form = new Form_ChangeInfor();
            Account_BLL acc = new Account_BLL();
            user_infor s = acc.GetInforUserByEmail(Account);
            form.SetInforAdmin(s);
            form.ShowDialog();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void Form_Infor_Admin_Load(object sender, EventArgs e)
        {
            Account_BLL acc = new Account_BLL();
            user_infor s = acc.GetInforUserByEmail(Account);
            this.lblEmail.Text = s.email_id;
            this.lblGioiTinh.Text = s.gender;
            DateTime dateTime = s.day_of_birth.Value;
            this.lblNgaySinh.Text = dateTime.ToShortDateString().ToString();
            this.lblTenNguoiDung.Text = s.full_name;
            this.lblSoDienThoai.Text = s.phone_number;
        }
    }
}
