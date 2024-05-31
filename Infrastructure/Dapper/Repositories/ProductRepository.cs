using Application.Interfaces;
using Dapper;
using Domain.Entities;
using static Infrastructure.Dapper.SqlConstants;

namespace Infrastructure.Dapper.Repositories;

public class ProductRepository : IProductRepository
{
    readonly DbContext _context;

    public ProductRepository(DbContext context)
    {
        _context = context;
    }

    //Create
    public async Task<int> AddProductAsync(Product product)
    {
        using (var connection = _context.CreateConnection())
        {
            return await connection.QuerySingleAsync<int>(ProductSql.CreateProduct, product);
        }
    }

    // Read
    public async Task<Product> GetProductByIdAsync(int id)
    {
        using (var connection = _context.CreateConnection())
        {
            return await connection.QuerySingleOrDefaultAsync<Product>(ProductSql.GetProductById, new { Id = id }) ??
                throw new KeyNotFoundException($"Product with id: {id} not found!");
        }
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        using (var connection = _context.CreateConnection())
        {
            var products = await connection.QueryAsync<Product>(ProductSql.GetAllProducts);
            return products.ToList();
        }
    }

    // Update
    public async Task<int> UpdateProductAsync(Product product)
    {
        using (var connection = _context.CreateConnection())
        {
            return await connection.ExecuteAsync(ProductSql.UpdateProduct, product);
        }
    }

    // Delete
    public async Task<int> DeleteProductAsync(int id)
    {
        using (var connection = _context.CreateConnection())
        {
            return await connection.ExecuteAsync(ProductSql.DeleteProduct, new { Id = id });
        }
    }
}