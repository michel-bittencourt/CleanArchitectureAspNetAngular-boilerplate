using Database.Context;
using Domain.Entities;
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

    public async Task Add<T>(T entity) where T : class
    {
        _productContext.Add(entity);
        await _productContext.SaveChangesAsync();
    }

    public async Task Update<T>(T entity) where T : class
    {
        _productContext.Update(entity);
        await _productContext.SaveChangesAsync();
    }

    public async Task Remove<T>(T entity) where T : class
    {
        _productContext.Remove(entity);
        await _productContext.SaveChangesAsync();
    }
}
