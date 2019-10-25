﻿// <auto-generated />
using AlcoholShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlcoholShop.Migrations
{
    [DbContext(typeof(AlcoholContext))]
    partial class AlcoholContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlcoholShop.Data.Entites.Alcohol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Alcohol_degree");

                    b.Property<string>("Alcohol_type");

                    b.Property<string>("Made_In");

                    b.Property<string>("Name");

                    b.Property<string>("Pulled_from");

                    b.Property<int>("Year_of_alcohol");

                    b.HasKey("Id");

                    b.ToTable("Alcohols");
                });
#pragma warning restore 612, 618
        }
    }
}
