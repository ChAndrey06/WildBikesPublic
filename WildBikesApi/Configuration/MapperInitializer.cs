﻿using AutoMapper;
using WildBikesApi.DTO.Booking;
using WildBikesApi.DTO.User;

namespace WildBikesApi.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Booking, BookingSignatureDTO>().ReverseMap();
            CreateMap<Booking, BookingCreateDTO>().ReverseMap();
            CreateMap<Booking, BookingReadDTO>().ReverseMap();

            CreateMap<User, UserReadDTO>().ReverseMap();
            CreateMap<User, UserLoginDTO>().ReverseMap();
        }
    }
}
