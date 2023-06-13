using pbl3_Cinema.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.ManageStaff
{
    public partial class Form_CRUD_Staff : Form
    {
        public delegate void Hiden();
        public Hiden hiden { set; get; }
        public string email_id { set; get; }
        public Form_CRUD_Staff()
        {
            InitializeComponent();
        }

        private void Init()
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
            ccbGioiTinh.SelectedIndex = 0;
            ccbTrangThai.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hiden();
            this.Dispose();
        }

        private int GetWage()
        {
            int wage = 0;
            try
            {
                wage = Convert.ToInt32(txtLuong.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lương sai định dạng");
                txtLuong.Text = "0";
                return 0;
            }
            if (wage < 0)
            {
                MessageBox.Show("Lương không được âm");
                txtLuong.Text = "0";
                return 0;
            }
            return wage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account_BLL acc = new Account_BLL();
            string email = txtEmail.Text.Trim();
            if (email == "")
            {
                MessageBox.Show("Email không được để trống");
                return;
            }
            if (MyFuncStatic.MyEmailFunc.checkValidEmail(email) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            string position = txtChucVu.Text;
            string name = txtHoTen.Text;
            string gender = ccbGioiTinh.SelectedItem.ToString();

            string phone = txtDienThoai.Text;
            if (checkValidPhoneNumber(phone) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            string password = txtPassword.Text;
            if (checkValidPassword(password) == false)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 6 đến 24 ký tự!");
                return;
            }

            int wage = GetWage();
            bool active = ccbTrangThai.SelectedItem.ToString() == "Active" ? true : false;
            DateTime dtp = (DateTime)dtpNgaySinh.Value;
            if (this.email_id == "")
            {
                if (acc.createAccountStaff(email, password, name, gender, phone, dtp, position, wage) == 1)
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    hiden();
                    this.Close();
                }
            }
            else
            {
                if (acc.UpdateInforStaff(email, password, name, gender, phone, dtp, position, wage, active) == 1)
                {
                    MessageBox.Show("Update thông tin nhân viên thành công");
                    hiden();
                    this.Close();
                }
            }

        }

        private void Form_CRUD_Staff_Load(object sender, EventArgs e)
        {
            Init();
            CinemaEntities db = new CinemaEntities();
            if (email_id != "")
            {
                var find = db.staffs.Where(p => p.email == email_id).Select(p => new { p.position, p.wage, p.email, p.account.active, p.user_infor.full_name, p.user_infor.day_of_birth, p.user_infor.gender, p.user_infor.phone_number, p.account.pass_word }).FirstOrDefault();
                txtHoTen.Text = find.full_name;
                dtpNgaySinh.Value = (DateTime)find.day_of_birth;
                txtChucVu.Text = find.position;
                txtEmail.Text = find.email;
                txtDienThoai.Text = find.phone_number;
                txtLuong.Text = find.wage.ToString();
                txtPassword.Text = find.pass_word;
                ccbGioiTinh.Text = find.gender.ToString();
                if (find.active == true)
                {
                    ccbTrangThai.Text = "Active";
                }
                else
                {
                    ccbTrangThai.Text = "Inactive";
                }
                txtEmail.ReadOnly = true;
            }
        }

        private bool checkValidPassword(string password)
        {
            if (password == null)
            {
                return false;
            }
            int length = password.Length;
            if (length < 6 || length > 24)
            {
                return false;
            }
            return true;
        }

        private bool checkValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
            {
                return false;
            }
            int length = phoneNumber.Length;
            if (length != 10)
            {
                return false;
            }
            for (int i = 0; i < length; i++)
            {
                if (phoneNumber[i] < 48 || phoneNumber[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
