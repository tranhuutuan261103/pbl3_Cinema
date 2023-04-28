using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3_Cinema.DAL;

namespace pbl3_Cinema.BLL
{
    public class Product_BLL
    {
        public bool AddProduct(product p)
        {
            try
            {
                Product_DAL objDAL = new Product_DAL();
                return objDAL.AddProduct(p);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message.ToString());
                return false;
            }

        }

        public bool EditProduct(int pHash, product p)
        {
            try
            {
                Product_DAL objDAL = new Product_DAL();
                return objDAL.EditProduct(pHash, p);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message.ToString());
                return false;
            }

        }

        internal List<product> GetListProduct()
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                List<product> listProduct = new List<product>();
                var list = db.products.Select(p => p);
                foreach (var product in list)
                {
                    listProduct.Add(product);
                }
                return listProduct;
            }    
        }
    }
}
