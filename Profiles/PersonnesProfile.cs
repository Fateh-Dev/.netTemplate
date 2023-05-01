using AutoMapper;
using template.Models;
using Template.Dtos;
using Template.Models;

namespace Template.Profiles
{
    public class PersonnesProfile : Profile
    {
        public PersonnesProfile()
        {
            CreateMap<Personne, PersonneReadDto>();
            CreateMap<Notation, NoteReadDto>();
            CreateMap<Notation, NoteReturnDto>().ForMember(t => t.TotalNote, opt => opt.MapFrom(t => t.Note * t.Coefficient));

        }
    }

}