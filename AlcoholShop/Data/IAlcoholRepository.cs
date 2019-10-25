using AlcoholShop.Data.Entites;
using AlcoholShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholShop.Data
{
    public interface IAlcoholRepository
    {
        Alcohol[]  Get_all_Alcohols();
        Alcohol Get_Alcohol_byId(int id);
        Alcohol Add(AlcoholModel model);
        void Delete(Alcohol entity);
        bool SaveChanges();

    }
}
