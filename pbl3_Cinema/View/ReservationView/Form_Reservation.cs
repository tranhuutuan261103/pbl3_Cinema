﻿using pbl3_Cinema.MyUserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.ReservationView
{
    public partial class Form_Reservation : Form
    {
        public int id_screening { set; get; }
        public string Account { set; get; }
        private Form_SeatMap activeForm_SeatMap;
        private Form_SelectProduct activeForm_Product;
        private List<seat_reserved> selectedSeat;
        private List<detail_bill> selectedProduct;
        public Form_Reservation()
        {
            InitializeComponent();
        }

        private void Form_Reservation_Load(object sender, EventArgs e)
        {
            label_Title.Text = "Đặt vé";
            Form_SeatMap form = new Form_SeatMap();
            form.id_screening = id_screening;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            activeForm_SeatMap = form;
            panel_Body.Controls.Add(activeForm_SeatMap);
            form.Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (label_Title.Text == "Đặt vé")
            {
                Close();
            }

            else if (label_Title.Text == "Thêm đồ ăn")
            {
                activeForm_Product.Visible = false;
                activeForm_SeatMap.Visible = true;
                label_Title.Text = "Đặt vé";
            }
        }

        private void btn_Continute_Click(object sender, EventArgs e)
        {
            if (label_Title.Text == "Đặt vé")
            {
                Form_SeatMap form_Seat = activeForm_SeatMap;
                selectedSeat = form_Seat.GetAllSelectedSeat();
                if (selectedSeat.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chổ ngồi");
                    return;
                }

                activeForm_SeatMap.Visible = false;
                label_Title.Text = "Thêm đồ ăn";
                Form_SelectProduct form_Product = new Form_SelectProduct();
                activeForm_Product = form_Product;
                form_Product.TopLevel = false;
                form_Product.Dock = DockStyle.Fill;
                panel_Body.Controls.Add(form_Product);
                form_Product.Show();
            }

            else if (label_Title.Text == "Thêm đồ ăn")
            {
                selectedProduct = activeForm_Product.GetInforSelectedProduct();
                Form_BookTicket form = new Form_BookTicket(Account,id_screening, selectedSeat, selectedProduct);
                form.cf += new Form_BookTicket.CloseForm(closeForm);
                form.ShowDialog();
            }
        }

        public void closeForm()
        {
            Dispose();
        }
    }
}
