using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class ProductService : IProductService
{
    readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    //Create
    public async Task<int> CreateProductAsync(Product product)
        => await _productRepository.AddProductAsync(product);

    //Read
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
        => await _productRepository.GetAllProductsAsync();

    public async Task<Product> GetProductByIdAsync(int id)
        => await _productRepository.GetProductByIdAsync(id);

    //Update
    public async Task<int> UpdateProductAsync(Product product)
        => await _productRepository.UpdateProductAsync(product);

    //Delete
    public async Task<int> DeleteProductAsync(int id)
        => await _productRepository.DeleteProductAsync(id);
}
