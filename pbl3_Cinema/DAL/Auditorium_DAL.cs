using pbl3_Cinema.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.DAL
{
    internal class Auditorium_DAL
    {

        public int AddAuditorium(auditorium a)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var l = db.auditoriums.Add(a);
                    db.SaveChanges();
                    AddSeat(a.id, a.seat_no_row, a.seat_no_column);
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int AddSeat(int id_auditorium, int seat_row, int seat_column)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                for (int i = 1; i <= seat_row; i++)
                {
                    for (int j = 1; j <= seat_column; j++)
                    {
                        seat s = new seat
                        {
                            auditorium_id = id_auditorium,
                            row_location = i,
                            column_location = j,
                        };
                        db.seats.Add(s);
                        db.SaveChanges();
                    }
                }
            }
            return 1;
        }

        public bool DeleteAuditorium(int id)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                try
                {
                    var result = db.auditoriums.Where(p => p.id == id).FirstOrDefault();
                    result.active = false;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<Auditorium_Infor> GetAllAuditorium_Infor()
        {
            List<Auditorium_Infor> list = new List<Auditorium_Infor>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var l = db.auditoriums.
                    Where(p => p.active == true).
                    GroupJoin(db.screenings.Where(p => p.show_day >= DateTime.Now).GroupBy(infor => infor.auditorium_id).Select(p => new { audi_id = p.Key, count = p.Count() }),
                    k1 => k1.id,
                    k2 => k2.audi_id,
                    (k1, k2) => new { k1, k2 })
                    .SelectMany(x => x.k2.DefaultIfEmpty(),
                    (k1, k2) => new { k1.k1.id, k1.k1.name_auditorium, k1.k1.seat_no_row, k1.k1.seat_no_column, count = k2 == null ? 0 : k2.count });

                foreach (var auditorium in l)
                {
                    list.Add(new Auditorium_Infor
                    {
                        id = auditorium.id,
                        name_auditorium = auditorium.name_auditorium,
                        seat_no_row = auditorium.seat_no_row,
                        seat_no_column = auditorium.seat_no_column,
                        screening_curent_count = auditorium.count,
                    });
                }
            }
            return list;
        }

        public List<CBBAuditorium> GetAllCBBAuditorimActive()
        {
            List<CBBAuditorium> listCBB = new List<CBBAuditorium>();
            using (CinemaEntities db = new CinemaEntities())
            {
                var list = db.auditoriums.Where(p => p.active == true).Select(p => new { p.id, p.name_auditorium });
                foreach (var item in list)
                {
                    listCBB.Add(new CBBAuditorium
                    {
                        id = item.id,
                        nameAuditorium = item.name_auditorium,
                    });
                }
            }
            return listCBB;
        }

        public auditorium GetAuditoriumByIdScreening(int id_screening)
        {
            using (CinemaEntities db = new CinemaEntities())
            {
                var audi = db.screenings.Where(p => p.id == id_screening).Select(p => new { p.id, p.auditorium_id }).
                    Join(db.auditoriums,
                    s => s.auditorium_id,
                    a => a.id,
                    (s, a) => new { a }).FirstOrDefault();
                if (audi == null)
                {
                    return null;
                }
                return new auditorium
                {
                    id = audi.a.id,
                    name_auditorium = audi.a.name_auditorium,
                    seat_no_column = audi.a.seat_no_column,
                    seat_no_row = audi.a.seat_no_row,
                    seats = audi.a.seats,
                    active = audi.a.active
                };
            }
        }
    }
}
