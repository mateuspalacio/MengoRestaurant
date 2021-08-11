using AutoMapper;
using Mengo.Services.ShoppingCartAPI.Models;
using Mengo.Services.ShoppingCartAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mengo.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap(); // automapper transforma productdto em product
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap(); // automapper transforma productdto em product
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap(); // automapper transforma productdto em product
                config.CreateMap<Cart, CartDto>().ReverseMap(); // automapper transforma productdto em product


            });

            return mappingConfig;
        }
    }
}
