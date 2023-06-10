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

namespace pbl3_Cinema.View.AdminView.ManageAccount
{
    public partial class Form_ManageAccount : Form
    {
        public Form_ManageAccount()
        {
            InitializeComponent();
        }

        private void Form_ManageAccount_Load(object sender, EventArgs e)
        {
            LoadInforAccountCustommer();
        }

        private void LoadInforAccountCustommer()
        {
            Account_BLL bll = new Account_BLL();
            dataGridView.DataSource = bll.GetInforAllCustomer();
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["email"].HeaderText = "Email";
            dataGridView.Columns["email"].DisplayIndex = 0;
            dataGridView.Columns["email"].Width = 200;
            dataGridView.Columns["NameUser"].HeaderText = "Tên người dùng";
            dataGridView.Columns["NameUser"].DisplayIndex = 1;
            dataGridView.Columns["NameUser"].Width = 100;
            dataGridView.Columns["PointUser"].HeaderText = "Điểm tích lũy";
            dataGridView.Columns["PointUser"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dataGridView.Columns["PhoneNumber"].Width = 70;
            dataGridView.Columns["PhoneNumber"].DisplayIndex = 5;
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa");
                return;
            }

            string email = dataGridView.SelectedRows[0].Cells["email"].Value.ToString();

            Account_BLL bll = new Account_BLL();
            if (MessageBox.Show("Xác nhận xóa " + email, "Xóa tài khoản",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if ( bll.SetActive(email, false)== true)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadInforAccountCustommer();
                    return;
                }
            }
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa");
                return;
            }

            string email = dataGridView.SelectedRows[0].Cells["email"].Value.ToString();

            Account_BLL bll = new Account_BLL();
            if (MessageBox.Show("Mở tài khoản " + email, "Kích hoạt tài khoản",  MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (bll.SetActive(email, true) == true)
                {
                    MessageBox.Show("Kích hoạt thành công");
                    LoadInforAccountCustommer();
                    return;
                }
            }
        }
    }
}
