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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_CRUD_Staff form = new Form_CRUD_Staff();
            form.email_id = "";
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa");
                return;
            }
            string email = guna2DataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
            Form_CRUD_Staff form = new Form_CRUD_Staff();
            form.email_id = email;
            form.ShowDialog();
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
        }
    }
}
