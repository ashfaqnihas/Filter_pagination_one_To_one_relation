using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.DTO;
using T_Shop.Application.DTO.Brand;
using T_Shop.Application.DTO.Product;
using T_Shop.Domain.Models;

namespace T_Shop.Application.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandDto>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ProductDto>()
                .ForMember(x => x.Category, opt => opt.MapFrom(source => source.Category.Name))
                .ForMember(x => x.Brand, opt => opt.MapFrom(source => source.Brand.Name));
        }
    }
}