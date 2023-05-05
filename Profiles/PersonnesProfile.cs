using AutoMapper;
using Template.Dtos;
using Template.Models;

namespace Template.Profiles
{
    public class PersonnesProfile : Profile
    {
        public PersonnesProfile()
        {
            CreateMap<Personne, PersonneReadDto>();

        }
    }

}