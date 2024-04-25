using System;
using Abril24.ITD.PERROSPERDIDOS.DOMAIN.INTERFACES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abril24.ITD.PERROSPERDIDOS.APPLICATION.SERVICES
    {
        public class AdministradorService
        {
            private readonly IAdministradorRepository _administradorRepository;

            public AdministradorService(IAdministradorRepository administradorRepository)
            {
                _administradorRepository = administradorRepository;
            }

            public async Task<int> AgregarAdministrador(string usuario, long telefono, string contrasena)
            {
                return await _administradorRepository.AgregarAdministrador(usuario, telefono, contrasena);
            }

            public async Task<int> ModificarNumeroCelular(int idUsuario, string contraseña, string nuevoNumeroCelular)
            {
                return await _administradorRepository.ModificarNumeroCelular(idUsuario, contraseña, nuevoNumeroCelular);
            }
        }

        public class MascotaPerdidaService
        {
            private readonly IMascotaPerdidaRepository _mascotaPerdidaRepository;

            public MascotaPerdidaService(IMascotaPerdidaRepository mascotaPerdidaRepository)
            {
                _mascotaPerdidaRepository = mascotaPerdidaRepository;
            }
        // ------------------------------------PROCEDIMIENTO PATCH-----------------------------------------
        public async Task<int> ModificarCaracteristicasPerroPerdido(int idMascota, string nuevasCaracteristicas)
            {
                return await _mascotaPerdidaRepository.ModificarCaracteristicasPerroPerdido(idMascota, nuevasCaracteristicas);
            }
        // ------------------------------------PROCEDIMIENTO POST-----------------------------------------
        public async Task<int> ReportarPerroPerdido(int idUsuario, int celular, string raza, string color, string tamano, char sexo, string caracteristicas, DateTime fechaVisto, string lugarVisto, byte[] imagen)
            {
                return await _mascotaPerdidaRepository.ReportarPerroPerdido(idUsuario, celular, raza, color, tamano, sexo, caracteristicas, fechaVisto, lugarVisto, imagen);
            }
        // ------------------------------------PROCEDIMIENTO GET-----------------------------------------
        public async Task<IEnumerable<MascotaPerdida>> ObtenerPublicacionesRecientes()
            {
                return await _mascotaPerdidaRepository.ObtenerPublicacionesRecientes();
            }
        }
    }


