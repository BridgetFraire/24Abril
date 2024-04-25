using System;
using Abril24.ITD.PERROSPERDIDOS.DOMAIN.INTERFACES;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Abril24.ITD.PERROSPERDIDOS.INFRAESTRUCTURE.REPOSITORIES
{
     public class AdministradorRepository : IAdministradorRepository
        {
            private readonly IDbConnection _dbConnection;

            public AdministradorRepository(IDbConnection dbConnection)
            {
                _dbConnection = dbConnection;
            }

            public async Task<int> AgregarAdministrador(string usuario, long telefono, string contrasena)
            {
                var parameters = new { p_usuario = usuario, p_telefono = telefono, p_contrasena = contrasena };
                return await _dbConnection.ExecuteAsync("alta_administrador", parameters, commandType: CommandType.StoredProcedure);
            }

            public async Task<int> ModificarNumeroCelular(int idUsuario, string contraseña, string nuevoNumeroCelular)
            {
                var parameters = new { p_id_usuario = idUsuario, p_contraseña = contraseña, p_nuevo_numero_celular = nuevoNumeroCelular };
                return await _dbConnection.ExecuteAsync("modificar_numero_celular", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public class MascotaPerdidaRepository : IMascotaPerdidaRepository
        {
            private readonly IDbConnection _dbConnection;

            public MascotaPerdidaRepository(IDbConnection dbConnection)
            {
                _dbConnection = dbConnection;
            }

            public async Task<int> ModificarCaracteristicasPerroPerdido(int idMascota, string nuevasCaracteristicas)
            {
                var parameters = new { p_id_mascota = idMascota, p_nuevas_caracteristicas = nuevasCaracteristicas };
                return await _dbConnection.ExecuteAsync("modificar_caracteristicas_perro_perdido", parameters, commandType: CommandType.StoredProcedure);
            }

            public async Task<int> ReportarPerroPerdido(int idUsuario, int celular, string raza, string color, string tamano, char sexo, string caracteristicas, DateTime fechaVisto, string lugarVisto, byte[] imagen)
            {
                var parameters = new { p_id_usuario = idUsuario, p_celular = celular, p_raza = raza, p_color = color, p_tamano = tamano, p_sexo = sexo, p_caracteristicas = caracteristicas, p_fecha_visto = fechaVisto, p_lugar_visto = lugarVisto, p_imagen = imagen };
                return await _dbConnection.ExecuteAsync("reportar_perro_perdido", parameters, commandType: CommandType.StoredProcedure);
            }

            public async Task<IEnumerable<MascotaPerdida>> ObtenerPublicacionesRecientes()
            {
                return await _dbConnection.QueryAsync<MascotaPerdida>("obtener_publicaciones_recientes", commandType: CommandType.StoredProcedure);
            }
        }
    }


