using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.DAL
{
    internal class Product_DAL
    {
        internal bool AddProduct(product p)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var l = db.products.Add(p);
                    db.SaveChanges();
                    
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        internal bool EditProduct(int pHash, product p)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var pTemp = db.products.Find(pHash);
                    pTemp.image_product = p.image_product;
                    pTemp.name_product = p.name_product;
                    pTemp.price = p.price;
                    pTemp.unit = p.unit;
                    pTemp.the_number_of_products = p.the_number_of_products;
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public void SetNumberOfProducts(int pHash, int value)
        {
            using(CinemaEntities db = new CinemaEntities())
            {
                var p = db.products.Find(pHash);
                if (p != null)
                {
                    p.the_number_of_products = value;
                    db.SaveChanges();
                }
            }
        }
    }
}
