using pbl3_Cinema.BLL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pbl3_Cinema.View.AdminView.ManageStaff
{
    public partial class Form_Manage_Staff : Form
    {
        public Form_Manage_Staff()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Chắc chắn muốn xóa chưa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<string> email_list = new List<string>();
                    foreach (DataGridViewRow i in guna2DataGridView1.SelectedRows)
                    {
                        string email = i.Cells["email"].Value.ToString();
                        email_list.Add(email);
                    }
                    Account_BLL acc = new Account_BLL();
                    if (acc.deleteAccountStaff(email_list) == 1)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình xóa");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
            }
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            hiden();
            Form_CRUD_Staff form = new Form_CRUD_Staff();
            form.hiden += new Form_CRUD_Staff.Hiden(visible);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.email_id = "";
            this.Controls.Add(form);
            form.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa");
                return;
            }
            string email = guna2DataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
            hiden();
            Form_CRUD_Staff form = new Form_CRUD_Staff();
            form.hiden += new Form_CRUD_Staff.Hiden(visible);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.email_id = email;
            this.Controls.Add(form);
            form.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Account_BLL bll = new Account_BLL();
            List<Staff_Infor> list_staff = bll.GetInforStaffByFullName(txtHoTen.Text);
            this.guna2DataGridView1.DataSource = list_staff;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns["nameUser"].HeaderText = "Tên nhân viên";
            guna2DataGridView1.Columns["nameUser"].Width = 150;
            guna2DataGridView1.Columns["nameUser"].DisplayIndex = 0;
            guna2DataGridView1.Columns["email"].HeaderText = "Email";
            guna2DataGridView1.Columns["email"].Width = 150;
            guna2DataGridView1.Columns["email"].DisplayIndex = 1;
            guna2DataGridView1.Columns["position"].HeaderText = "Chức vụ";
            guna2DataGridView1.Columns["position"].Width = 100;
            guna2DataGridView1.Columns["position"].DisplayIndex = 2;
            guna2DataGridView1.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            guna2DataGridView1.Columns["PhoneNumber"].Width = 70;
            guna2DataGridView1.Columns["wage"].HeaderText = "Lương";
            guna2DataGridView1.Columns["wage"].Width = 50;
            guna2DataGridView1.Columns["wage"].DisplayIndex = 3;
            guna2DataGridView1.Columns["wage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void hiden()
        {
            foreach(Control control in this.Controls)
            {
                control.Visible = false;
            }
        }

        public void visible()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
