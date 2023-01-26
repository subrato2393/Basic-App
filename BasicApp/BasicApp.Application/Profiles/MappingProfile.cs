using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BasicApp.Application.DTOs.Product;
using BasicApp.Domain;

namespace BasicApp.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<Product,ProductDto>().ReverseMap();
        }
    }
}
