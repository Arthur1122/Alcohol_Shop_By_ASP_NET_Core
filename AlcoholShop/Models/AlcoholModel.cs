using AlcoholShop.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholShop.Models
{
    public class AlcoholModel
    {
        public string Model_Name { get; set; }
        public string Model_Alcohol_type { get; set; }
        public int Model_Year_of_alcohol { get; set; }
        public double Model_Alcohol_degree { get; set; }
        public string Model_Made_In { get; set; }
        public string Model_Pulled_from { get; set; }

    }
}
