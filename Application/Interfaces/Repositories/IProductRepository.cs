namespace Application.Interfaces.Repositories;

using Domain;

public interface IProductRepository
{
    // Create
    public Task<int> AddProductAsync(Product product);

    // Read
    public Task<Product> GetProductByIdAsync(int id);

    public Task<IEnumerable<Product>> GetAllProductsAsync();

    // Update
    public Task<int> UpdateProductAsync(Product product);

    // Delete
    public Task<int> DeleteProductAsync(int id);
}
