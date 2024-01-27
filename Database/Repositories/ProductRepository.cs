using Database.Context;
using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories;

public class ProductRepository : IProductRepository
{
    ApplicationDbContext _productContext;
    public ProductRepository(ApplicationDbContext context)
    {
        _productContext = context;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _productContext.Products.ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(int? id)
    {
        return await _productContext.Products.FindAsync(id);
    }
}
