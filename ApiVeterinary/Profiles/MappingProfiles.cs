using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiVeterinary.Dtos.Get.Location;
using ApiVeterinary.Dtos.Get.Person;
using ApiVeterinary.Dtos.Get.Pet;
using ApiVeterinary.Dtos.Get.ProvidedServices;
using ApiVeterinary.Dtos.Post.Location;
using ApiVeterinary.Dtos.Post.Person;
using ApiVeterinary.Dtos.Post.Pet;
using ApiVeterinary.Dtos.Post.ProvidedServices;
using AutoMapper;
using Domain.Entities.Location;
using Domain.Entities.Person;
using Domain.Entities.Pet;
using Domain.Entities.ProvidedServices;

namespace ApiVeterinary.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<City, CityDto>()
        .ReverseMap();
        CreateMap<City, CityPDto>()
        .ReverseMap();

        CreateMap<Country, CountryDto>()
        .ReverseMap();

        CreateMap<Department, DepartmentDto>()
        .ReverseMap();
        CreateMap<Department, DepartmentPDto>()
        .ReverseMap();

        CreateMap<Address, AddressDto>()
        .ReverseMap();
        CreateMap<Address, AddressPDto>()
        .ReverseMap();

        CreateMap<Client, ClientDto>()
        .ReverseMap();

        CreateMap<ClientContact, ClientContactDto>()
        .ReverseMap();
        CreateMap<ClientContact, ClientContactPDto>()
        .ReverseMap();

        CreateMap<CPet, PetDto>()
        .ReverseMap();
        CreateMap<CPet, PetPDto>()
        .ReverseMap();

        CreateMap<PetBred, PetBredDto>()
        .ReverseMap();

        CreateMap<Appointment, AppointmentDto>()
        .ReverseMap();
        CreateMap<Appointment, AppointmentPDto>()
        .ReverseMap();

        CreateMap<Service, ServiceDto>()
        .ReverseMap();
    }
}
