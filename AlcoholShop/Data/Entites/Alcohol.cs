using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholShop.Data.Entites
{
    public class Alcohol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AlcoholTypes Alcohol_type { get; set; }
        public int Year_of_alcohol { get; set; }
        public double Alcohol_degree { get; set; }
        public string Made_In { get; set; }
        public string Pulled_from { get; set; }

    }
}
