using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abril24.ITD.PERROSPERDIDOS.DOMAIN.INTERFACES
{
        public interface IAdministradorRepository
        {
            Task<int> AgregarAdministrador(string usuario, long telefono, string contrasena);
            Task<int> ModificarNumeroCelular(int idUsuario, string contraseña, string nuevoNumeroCelular);
        }

        public interface IMascotaPerdidaRepository
        {
            Task<int> ModificarCaracteristicasPerroPerdido(int idMascota, string nuevasCaracteristicas);
            Task<int> ReportarPerroPerdido(int idUsuario, int celular, string raza, string color, string tamano, char sexo, string caracteristicas, DateTime fechaVisto, string lugarVisto, byte[] imagen);
            Task<IEnumerable<MascotaPerdida>> ObtenerPublicacionesRecientes();
        }
    }


