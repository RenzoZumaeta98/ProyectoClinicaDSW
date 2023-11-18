using AutoMapper;
using SolClinicaHealth.DataAccess.Entities;
using SolClinicaHealth.Models;

namespace SolClinicaHealth.Profiles
{
	public class UsuarioProfile : Profile
	{
		public UsuarioProfile()
		{
			CreateMap<UsuarioEntity, UsuarioViewModel>()
			.ForMember(dest => dest.IdUsuario, opt => opt.MapFrom(src => src.IdUsuario))
			.ReverseMap();
		}
	}
}
