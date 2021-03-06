using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Rest_Mercado.Domains.Models;
using API_Rest_Mercado.Extensions;
using API_Rest_Mercado.Resources;
using AutoMapper;


namespace API_Rest_Mercado.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}