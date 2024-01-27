namespace Domain.Interfaces;

public interface IProductRepository
{
    //IEnumerable eh mais pratico e seguro quando quer apenas iterar sobre a colecao de elementos
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetProductByIdAsync(int? id);
}
