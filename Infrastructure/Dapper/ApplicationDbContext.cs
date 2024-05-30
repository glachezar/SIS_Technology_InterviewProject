using System.Data;
using Dapper;
using Domain;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Dapper;

public class ApplicationDbContext
{
    readonly IConfiguration _configuration;
    readonly string _connectionString;

    public ApplicationDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }

    public async void CreateDatabase()
    {
        const string sql = "";
        using (var connection = CreateConnection())
        {

        }
    }
}