﻿using AirLineAPI.Model;
using AutoMapper;
using AirLineAPI.Dto;


namespace AirLineAPI.Configuration
{
    public class MappedProfile : Profile
    {
        public MappedProfile()
        {
            CreateMap<Passenger, PassengerDto>()
                .ReverseMap();
            CreateMap<Destination, DestinationDto>()
                .ReverseMap();
            CreateMap<Passenger, PassengerDto>()
               .ReverseMap();


        }
    }
}
