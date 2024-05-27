using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace SIS_Technology_InterviewProject.Data;

public class ProductService
{
    readonly IConfiguration _configuration;
    readonly string _connectionString;

    public ProductService(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }

    //Add
    public async Task<int> AddProductAsync(Product product)
    {
        const string sql = "INSERT INTO Products (ProductName, Category, UnitPrice, DateAdded) VALUES (@ProductName, @Category, @UnitPrice, @DateAdded); SELECT CAST(SCOPE_IDENTITY() as int);";
        using (var connection = CreateConnection())
        {
            return await connection.QuerySingleAsync<int>(sql, product);
        }
    }

    // Read
    public async Task<Product> GetProductByIdAsync(int id)
    {
        const string sql = "SELECT * FROM Products WHERE Id = @Id";
        using (var connection = CreateConnection())
        {
            return await connection.QuerySingleOrDefaultAsync<Product>(sql, new { Id = id });
        }
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        const string sql = "SELECT * FROM Products";
        using (var connection = CreateConnection())
        {
            return await connection.QueryAsync<Product>(sql);
        }
    }

    // Update
    public async Task<int> UpdateProductAsync(Product product)
    {
        const string sql = "UPDATE Products SET ProductName = @ProductName, Category = @Category, UnitPrice = @UnitPrice, DateAdded = @DateAdded WHERE Id = @Id";
        using (var connection = CreateConnection())
        {
            return await connection.ExecuteAsync(sql, product);
        }
    }

    // Delete
    public async Task<int> DeleteProductAsync(int id)
    {
        const string sql = "DELETE FROM Products WHERE Id = @Id";
        using (var connection = CreateConnection())
        {
            return await connection.ExecuteAsync(sql, new { Id = id });
        }
    }
}