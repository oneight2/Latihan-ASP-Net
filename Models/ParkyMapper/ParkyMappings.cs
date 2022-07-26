using AutoMapper;
using ParkAPI.Models.Dtos;

namespace ParkAPI.Models.ParkyMapper
{
    public class ParkyMappings:Profile
    {
        public ParkyMappings()
        {
            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
        }
    }
}
