using System;
using AutoMapper;
using ContactlyAPI.Models;
using ContactlyAPI.Models.Domain;

namespace ContactlyAPI.Helpers.Mapper;


public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AddContactRequestDTO, Contact>();
    }

}