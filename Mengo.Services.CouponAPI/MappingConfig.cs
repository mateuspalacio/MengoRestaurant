using AutoMapper;
using Mengo.Services.CouponAPI.Models;
using Mengo.Services.CouponAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mengo.Services.CouponAPI
{
    public class MappingConfig
    {

        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap(); // automapper transforma productdto em product
                //config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap(); // automapper transforma productdto em product
                //config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap(); // automapper transforma productdto em product
                //config.CreateMap<Cart, CartDto>().ReverseMap(); // automapper transforma productdto em product


            });

            return mappingConfig;
        }
    }
}
