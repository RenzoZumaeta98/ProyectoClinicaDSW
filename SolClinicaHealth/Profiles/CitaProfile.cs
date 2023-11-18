using AutoMapper;
using SolClinicaHealth.DataAccess.Entities;
using SolClinicaHealth.Models;

namespace SolClinicaHealth.Profiles
{
    public class CitaProfile : Profile
    {
        public CitaProfile()
        {
            CreateMap<CitaEntity, CitaViewModel>()
            .ForMember(dest => dest.IdCita, opt => opt.MapFrom(src => src.IdCita))
            .ReverseMap();
        }
    }
}
