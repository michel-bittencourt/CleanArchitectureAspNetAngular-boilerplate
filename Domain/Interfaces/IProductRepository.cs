using Domain.Entities;

namespace Domain.Interfaces;

public interface IProductRepository : IGeneralRepository
{
    //IEnumerable eh mais pratico e seguro quando quer apenas iterar sobre a colecao de elementos
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetProductByIdAsync(int? id);
}
