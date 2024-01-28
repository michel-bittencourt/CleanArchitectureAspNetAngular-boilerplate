using Application.DTOs;

namespace Application.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductDTO>> GetProductsAsync();
    Task<ProductDTO> GetProductByIdAsync(int? id);

    Task Add(ProductDTO productDTO);
    Task Update(ProductDTO productDTO);
    Task Remove(int? id);
}
