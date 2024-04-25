using System.Data;
using System.Threading.Tasks;
using Abril24.ITD.PERROSPERDIDOS.DOMAIN.INTERFACES;

public class AdministradorRepository : IAdministradorRepository
{
    public readonly IDbConnection _dbConnection;

    public AdministradorRepository(string connectionString)
    {
        _dbConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
    }

    public Task<int> AgregarAdministrador(string usuario, long telefono, string contrasena)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> ModificarNumeroCelular(int idUsuario, string contraseña, string nuevoNumeroCelular)
    {
        throw new System.NotImplementedException();
    }

    // ...dotnet add .bridgettejosefinafrairedominguez@MacBook-de-Brid Abril24 package MySql.Data

}
