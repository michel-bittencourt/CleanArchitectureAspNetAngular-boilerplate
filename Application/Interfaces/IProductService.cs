using Application.DTOs;

namespace Application.Interfaces;

public interface IProductService : IGeneralService
{
    Task<IEnumerable<ProductDTO>> GetProductsAsync();
    Task<ProductDTO> GetProductByIdAsync(int? id);
}
