using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DTO
{
    internal class CBB_Category
    {
        public int id {  get; set; }
        public string name_Category { get; set; }
        public CBB_Category()
        {

        }
        public CBB_Category(DataRow dr) 
        {
            id = Convert.ToInt32(dr["id"]);
            name_Category = dr["name_category"].ToString();
            
        }

        public CBB_Category(int id, string name_Category)
        {
            this.id = id;
            this.name_Category = name_Category;
        }

        public override string ToString()
        {
            return name_Category;
        }
    }
}
