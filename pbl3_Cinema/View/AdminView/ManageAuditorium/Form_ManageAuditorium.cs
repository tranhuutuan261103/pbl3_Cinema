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

namespace pbl3_Cinema.View.AdminView.ManageScreen
{
    public partial class Form_ManageAuditorium : Form
    {
        public Form_ManageAuditorium()
        {
            InitializeComponent();
            GetAllAuditorium_Infor();
        }

        public void GetAllAuditorium_Infor()
        {
            Cinema_BLL bll = new Cinema_BLL();
            dataGridView_Auditorium.DataSource = bll.GetAllAuditorium_Infor();
            dataGridView_Auditorium.Columns["id"].Visible = false;
        }

        private void btn_AddAuditorium_Click(object sender, EventArgs e)
        {
            Form_AddAuditorium form = new Form_AddAuditorium();
            form.ShowDialog();
            GetAllAuditorium_Infor();
        }

        private void btn_DelAuditorium_Click(object sender, EventArgs e)
        {
            if (dataGridView_Auditorium.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng muốn xóa");
                return;
            }
            int auditorium_id = Convert.ToInt32(dataGridView_Auditorium.SelectedRows[0].Cells["id"].Value);
            Cinema_BLL bll = new Cinema_BLL();
            int count = bll.GetScreeningCurCount(auditorium_id);
            if (count > 0)
            {
                MessageBox.Show("Không thể xóa vì có suất chiếu đang chiếu");
                return;
            }
            else if (count == 0)
            {
                if (MessageBox.Show("Xác nhận xóa phòng chiếu này?","Xóa",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                if (bll.DeleteAuditorium(auditorium_id) == true)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            GetAllAuditorium_Infor();
        }
    }
}
