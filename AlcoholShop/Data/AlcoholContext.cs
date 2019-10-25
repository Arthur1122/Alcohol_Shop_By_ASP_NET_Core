using AlcoholShop.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholShop.Data
{
    public class AlcoholContext:DbContext
    {
        private readonly IConfiguration _config;
        public AlcoholContext(DbContextOptions options ,IConfiguration confiig) : base(options)
        {
            _config = confiig;
        }
        public DbSet<Alcohol> Alcohols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("AlcoholDB"));
        }
    }
}
