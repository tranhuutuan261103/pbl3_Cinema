﻿using pbl3_Cinema.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.View.AdminView.ManageBooking
{
    public partial class Form_ManageSeatMap : Form
    {
        private Button[,] btn;
        public int id_screening { set; get; }
        private List<seat_reserved> _selectedSeat;
        public List<seat_reserved> selectedSeat
        {
            get
            {
                return _selectedSeat;
            }
            private set { }
        }
        public Form_ManageSeatMap()
        {
            InitializeComponent();
            _selectedSeat = new List<seat_reserved>();
            panel_MapSeat.Size = new System.Drawing.Size(this.Width, this.Height);
        }

        private void myInit()
        {
            Cinema_BLL bll = new Cinema_BLL();
            Auditorium_BLL auditorium_BLL = new Auditorium_BLL();
            auditorium audi = auditorium_BLL.GetAuditoriumByIdScreening(id_screening);

            Seat_BLL seat_BLL = new Seat_BLL();
            List<seat_reserved> listSeat_Reserved = seat_BLL.GetAllSeat_ReservedsById(id_screening);
            List<seat> listReservedSeatLocation = seat_BLL.GetAllReservedSeatLocation(listSeat_Reserved);

            int x = audi.seat_no_row, y = audi.seat_no_column;
            int pading_top = 100;
            int pading_bottom = 50;
            int pading_left = 50;
            int pading_right = 50;

            panel_MapSeat.Paint += new PaintEventHandler(DrawScreeningMap);
            DrawSeatMap(x, y, pading_left, pading_right, pading_top, pading_bottom);
            SetIdToButtons(audi);
            AddReservedSeat(listReservedSeatLocation);
        }

        private void DrawSeatMap(int x, int y, int pading_left, int pading_right, int pading_top, int pading_bottom)
        {
            int space = 0;
            panel_MapSeat.Size = new Size(pading_left + pading_right + y * 50, pading_top + pading_bottom + x * 50);
            if (panel_MapSeat.Size.Width < Width)
            {
                space = (Width - panel_MapSeat.Size.Width) / 2;
                panel_MapSeat.Size = new Size(Width, panel_MapSeat.Size.Height);
            }
            btn = new Button[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Text = (char)(i + 65) + (j + 1).ToString();
                    btn[i, j].Location = new Point(pading_left + 50 * j + space, pading_top + 50 * i);
                    btn[i, j].Size = new Size(40, 40);
                    btn[i, j].Cursor = Cursors.Hand;
                    btn[i, j].Click += new EventHandler(clicked_Seat);
                    panel_MapSeat.Controls.Add(btn[i, j]);
                }
            }
        }

        private void clicked_Seat(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == DefaultBackColor)
            {
                MessageBox.Show("Chưa đặt");
                return;
            }
            int seat_id = Convert.ToInt32(btn.Name);
            Seat_BLL bll = new Seat_BLL();
            seat_reserved s = bll.GetSeat_Reserved(id_screening, seat_id);
            if (s == null)
            {
                return;
            }

            Form_InforBooking_Admin form = new Form_InforBooking_Admin()
            {
                id_screening = id_screening,
                id_reservation = s.reservation_id
            };

            form.ShowDialog();
        }

        private void SetIdToButtons(auditorium audi)
        {
            foreach (seat s in audi.seats)
            {
                int locaX = s.row_location;
                int locaY = s.column_location;
                btn[locaX - 1, locaY - 1].Name = s.id.ToString();
            }
        }

        private void DrawScreeningMap(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, new Rectangle(panel.Width / 2 - 120, 20, 240, 30));
            Label label = new Label();
            label.Name = "ManHinhChieu";
            label.Text = "Màn hình chiếu";
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.AutoSize = false;
            label.Location = new Point(panel.Width / 2 - 120, 20);
            label.Size = new Size(240, 30);
            label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(label);
        }

        private void AddReservedSeat(List<seat> list)
        {
            foreach (seat s in list)
            {
                int locaX = s.row_location;
                int locaY = s.column_location;
                btn[locaX - 1, locaY - 1].BackColor = Color.Red;
            }
        }

        private void Form_ManageSeatMap_Load(object sender, EventArgs e)
        {
            myInit();
        }
    }
}
