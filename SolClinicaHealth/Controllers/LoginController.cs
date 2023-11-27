using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolClinicaHealth.DataAccess;
using SolECommerce.CustomExtensions;
using SolClinicaHealth.DataAccess.Entities;
using SolClinicaHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolClinicaHealth.Controllers
{
    public class LoginController : Controller
    {
        private readonly ProyectoClinicaContext _context;
		private readonly IMapper _mapper;

		public LoginController(ProyectoClinicaContext context, IMapper mapper)
        {
            this._context = context;
			_mapper = mapper;

		}


        public IActionResult PaginaUsuario(UsuarioViewModel usuarioViewModel)
        {
			var usuarioIngreso = _context.Usuario.Where(c => c.CorreoUsuario == usuarioViewModel.CorreoUsuario && c.ClaveUsuario == usuarioViewModel.ClaveUsuario).Single();
			var usuarioInView = _mapper.Map<UsuarioViewModel>(usuarioIngreso) ;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Todavia no implementado
            UsuarioViewModel temporalUsuario = null; 

            if (HttpContext.Session.Get<UsuarioViewModel>("UsuarioIngreso") == null)
            {
                temporalUsuario = new UsuarioViewModel();
            }
            temporalUsuario = usuarioViewModel;
            HttpContext.Session.Set<UsuarioViewModel>("UsuarioIngreso", temporalUsuario);



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            return View(usuarioInView);
        }




		[HttpPost]
		public IActionResult ValidarUsuario(UsuarioViewModel usuarioViewModel)
		{

			return RedirectToAction("Index", "Home");
		}

		
    }
}
