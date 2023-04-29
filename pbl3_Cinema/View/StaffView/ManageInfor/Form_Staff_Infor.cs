using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
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

namespace pbl3_Cinema.View.CustomerView.ManageInfor
{
    public partial class Form_Staff_Infor : Form
    {
        public string Account { get; set; }
        public Form_Staff_Infor()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form_ForgotPassword form = new Form_ForgotPassword();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void Form_Staff_Infor_Load(object sender, EventArgs e)
        {
            Account_BLL acc = new Account_BLL();
            Staff_Infor s = acc.GetInforStaffByEmail(Account);
            this.lblEmail.Text = s.email;
            this.lblGioiTinh.Text = s.Gender;
            DateTime dateTime = s.DayOfBirth;
            this.lblNgaySinh.Text = dateTime.ToShortDateString().ToString();
            this.lblTenNguoiDung.Text = s.nameUser;
            this.lblSoDienThoai.Text = s.PhoneNumber;
            this.lblChucVu.Text = s.position;
            this.lblWage.Text = s.wage.ToString();
        }
    }
}
