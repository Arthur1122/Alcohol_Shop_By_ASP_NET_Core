using AlcoholShop.Data.Entites;
using AlcoholShop.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholShop.Data
{
    public class AlcoholProfile : Profile
    {
        public AlcoholProfile()
        {
            this.CreateMap<Alcohol, AlcoholModel>()
                .ForMember(a => a.Model_Id, o => o.MapFrom(m => m.Id))
                .ForMember(a => a.Model_Name, o => o.MapFrom(m => m.Name))
                .ForMember(a => a.Model_Alcohol_degree, o => o.MapFrom(m => m.Alcohol_degree))
                .ForMember(a => a.Model_Alcohol_type, o => o.MapFrom(m => m.Alcohol_type))
                .ForMember(a => a.Model_Made_In, o => o.MapFrom(m => m.Made_In))
                .ForMember(a => a.Model_Pulled_from, o => o.MapFrom(m => m.Pulled_from))
                .ForMember(a => a.Model_Year_of_alcohol, o => o.MapFrom(m => m.Year_of_alcohol))
                .ReverseMap();
                
            this.CreateMap<AlcoholModel,Alcohol>()
                .ForMember(a => a.Id, o => o.MapFrom(m => m.Model_Id))
                .ForMember(a => a.Name, o => o.MapFrom(m => m.Model_Name))
                .ForMember(a => a.Alcohol_degree, o => o.MapFrom(m => m.Model_Alcohol_degree))
                .ForMember(a => a.Alcohol_type, o => o.MapFrom(m => m.Model_Alcohol_type))
                .ForMember(a => a.Made_In, o => o.MapFrom(m => m.Model_Made_In))
                .ForMember(a => a.Pulled_from, o => o.MapFrom(m => m.Model_Pulled_from))
                .ForMember(a => a.Year_of_alcohol, o => o.MapFrom(m => m.Model_Year_of_alcohol))
                .ReverseMap();

        }
    }
}
