using pbl3_Cinema.DAL;
using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3_Cinema.BLL
{
    internal class Cinema_BLL
    {
        internal int AddCategory(category c)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.AddCategory(c);
        }
        public List<CBB_Category> GetAllCBBCategory()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetAllCBBCategory();
        }

        public List<MyMovieInfor> GetAllMovieInfor()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetAllMovieInfor();
        }

        public List<MyMovieInfor> GetAllMovieInfor(int id_category)
        {
            Cinema_DAL dal = new Cinema_DAL();
            List<MyMovieInfor> list = new List<MyMovieInfor>();
            foreach (MyMovieInfor item in dal.GetAllMovieInfor())
            {
                if (item.Category.id == id_category)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public void AddFilm(movie Movie)
        {
            Cinema_DAL dal = new Cinema_DAL();
            dal.AddFilm(Movie);
        }

        public void UpdateFilm(movie Movie)
        {
            Cinema_DAL dal = new Cinema_DAL();
            dal.UpdateFilm(Movie);
        }

        public MyMovieInfor GetMovieById(int id)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetMovieById(id);
        }

        public List<MyMovieInfor> GetAllMovieInforValidDay(int id_Category)
        {
            Cinema_DAL dal = new Cinema_DAL();
            if (id_Category == 0)
            {
                return dal.GetAllMovieInforValidDay();
            }
            return dal.GetAllMovieInforValidDay(id_Category);
        }

        public List<MyMovieInfor> GetAllMovieInforUpComing(int id_Category)
        {
            Cinema_DAL dal = new Cinema_DAL();
            if (id_Category == 0)
            {
                return dal.GetAllMovieInforUpComing();
            }
            return dal.GetAllMovieInforUpComing(id_Category);
        }

        public List<CBBMovie> GetCBBMoviesNow()
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetCBBMoviesNow();
        }

        public int GetDurationOfMovie(int id_movie)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return dal.GetDurationOfMovie(id_movie);
        }

        public Image GetPosterById(int id)
        {
            Cinema_DAL dal = new Cinema_DAL();
            return MyFuncStatic.MyConvert.ConvertBinaryToImage(dal.GetPosterById(id));
        }

    }
}
