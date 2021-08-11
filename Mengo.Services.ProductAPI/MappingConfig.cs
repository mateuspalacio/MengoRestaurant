using AutoMapper;
using Mengo.Services.ProductAPI.Models;
using Mengo.Services.ProductAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mengo.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>(); // automapper transforma productdto em product
                config.CreateMap<Product, ProductDto>(); // e vice versa

            });

            return mappingConfig;
        }
    }
}
