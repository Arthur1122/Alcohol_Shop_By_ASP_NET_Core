using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcoholShop.Data.Entites;
using AlcoholShop.Models;

namespace AlcoholShop.Data
{
    public class AlcoholRepository : IAlcoholRepository
    {
        private readonly AlcoholContext _context;

        public AlcoholRepository(AlcoholContext context)
        {
            this._context = context;
        }

        public Alcohol Add(AlcoholModel model)
        {
            Alcohol alcohol = new Alcohol
            {
                Name = model.Model_Name,
                Alcohol_type = model.Model_Alcohol_type,
                Alcohol_degree = model.Model_Alcohol_degree,
                Pulled_from = model.Model_Pulled_from,
                Year_of_alcohol = model.Model_Year_of_alcohol,
                Made_In = model.Model_Made_In
            };

            _context.Add(alcohol);
            _context.SaveChanges();

            return alcohol;
        }

        public void Delete(Alcohol entity)
        {
            _context.Remove(entity);
        }

        public Alcohol Get_Alcohol_byId(int id)
        {
            return _context.Find<Alcohol>(id);
        }

        public Alcohol[] Get_all_Alcohols()
        {
            IQueryable<Alcohol> query = _context.Alcohols;
            return query.ToArray();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
