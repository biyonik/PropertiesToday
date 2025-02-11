using Application.Models;
using AutoMapper;
using Domain;

namespace Application.Mappings;

public class Profiles: Profile
{
    public Profiles()
    {
        CreateMap<NewPropertyRequest, Property>().ReverseMap();
    }
}