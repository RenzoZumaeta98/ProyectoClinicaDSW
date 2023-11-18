using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolClinicaHealth.DataAccess;
using SolClinicaHealth.DataAccess.Entities;
using SolClinicaHealth.Models;
using System;
using System.Linq;

namespace SolClinicaHealth.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ProyectoClinicaContext _context;
        private readonly IMapper _mapper;

        public UsuarioController(ProyectoClinicaContext context, IMapper mapper)
        {
            this._context = context;
            _mapper = mapper;

        }

        [HttpPost]
        public IActionResult RegistrarUsuario(UsuarioViewModel usuarioViewModel)
        {
            var usuarioRegistro = _context.Usuario.Add(new UsuarioEntity()
            {
                NombreUsuario = usuarioViewModel.NombreUsuario.ToString(),
                ApellidoUsuario = usuarioViewModel.ApellidoUsuario.ToString(),
                CorreoUsuario = usuarioViewModel.CorreoUsuario.ToString(),
                ClaveUsuario = usuarioViewModel.ClaveUsuario.ToString(),
                FechaNacUsuario = DateTime.Parse(usuarioViewModel.FechaNacUsuario),
                Documento = _context.Documento.Where(c => c.IdDocumento.ToString() == usuarioViewModel.TipoDocumento.ToString()).SingleOrDefault(),
                NroDocumentoUsuario = usuarioViewModel.NroDocumentoUsuario.ToString(),
                CelularUsuario = usuarioViewModel.CelularUsuario.ToString(),
                GeneroUsuario = usuarioViewModel.GeneroUsuario.ToString(),
                DireccionUsuario = usuarioViewModel.DireccionUsuario.ToString(),
                TipoUsuario = _context.TipoUsuario.Where(c => c.IdTipoUsuario.ToString() == usuarioViewModel.TipoUsuario.ToString()).SingleOrDefault()

            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
