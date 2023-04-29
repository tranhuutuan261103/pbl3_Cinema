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
        public string email_id { set; get; }
        public Form_CRUD_Staff()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account_BLL acc = new Account_BLL();
            string email = txtEmail.Text;
            string position = txtChucVu.Text;
            string name = txtHoTen.Text;
            string gender = ccbGioiTinh.SelectedItem.ToString();
            int wage = Convert.ToInt32(txtLuong.Text);
            string phone = txtDienThoai.Text;
            string password = txtPassword.Text;
            DateTime dtp = (DateTime)dtpNgaySinh.Value;
            if (this.email_id == "")
            {
                if (acc.createAccountStaff(email, password, name, gender, phone, dtp, position, wage) == 1)
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    this.Close();
                }
            }
            else
            {
                if (acc.UpdateInforStaff(email, name, gender, phone, dtp, position, wage) == 1)
                {
                    MessageBox.Show("Update thông tin nhân viên thành công");
                    this.Close();
                }
            }

        }

        private void Form_CRUD_Staff_Load(object sender, EventArgs e)
        {
            CinemaEntities db = new CinemaEntities();
            if (email_id != "")
            {
                var find = db.staffs.Where(p => p.email == email_id).Select(p => new { p.position, p.wage, p.email, p.account.active, p.user_infor.full_name, p.user_infor.day_of_birth, p.user_infor.gender, p.user_infor.phone_number, p.account.pass_word }).FirstOrDefault();
                txtHoTen.Text = find.full_name;
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
            }
        }
    }
}
