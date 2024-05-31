using Domain.Entities;

namespace Application.Interfaces;

public interface IProductService
{
    //Create
    public Task<int> CreateProductAsync(Product product);

    //Read
    public Task<IEnumerable<Product>> GetAllProductsAsync();

    public Task<Product> GetProductByIdAsync(int id);

    //Update
    public Task<int> UpdateProductAsync(Product product);

    //Delete
    public Task<int> DeleteProductAsync(int id);
}
