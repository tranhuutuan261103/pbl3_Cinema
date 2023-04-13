using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class Auditorium_Infor
    {
        public int id {  get; set; }
        [Column("Tên phòng chiếu")]
        public string name_auditorium { get; set; }
        [Column("Số hàng")]
        public int seat_no_row { get; set; }
        [Column("Số cột")]
        public int seat_no_column { get; set; }
        [Column("Số suất chiếu đang chiếu")]
        public int screening_curent_count { get; set; }
    }
}
