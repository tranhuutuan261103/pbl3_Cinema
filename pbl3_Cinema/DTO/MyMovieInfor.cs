using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class MyMovieInfor
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CBB_Category _Category;
        public CBB_Category Category { 
            set
            {
                _Category = value;
            }
            get
            {
                if (_Category == null)
                {
                    _Category = new CBB_Category();
                }
                return _Category;
            }
        }
        public string Description { get; set; }
        public string Director { get; set; }
        public int Duration_min { get; set; }
        public string ListCast { get; set; }
        public DateTime Release_date { set; get; }
        public DateTime Expiration_date { set; get; }
        public MyMovieInfor() 
        {
        }
        
    }
}
