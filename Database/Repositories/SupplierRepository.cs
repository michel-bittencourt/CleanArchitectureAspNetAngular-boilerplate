using Domain.Entities;
using Domain.Interfaces;

namespace Database.Repositories;

public class SupplierRepository : ISupplierRepository
{


    public Task Add<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }

    public Task<Supplier> GetSupplierByIdAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Supplier>> GetSuppliersAsync(Supplier supplier)
    {
        throw new NotImplementedException();
    }

    public Task Remove<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }

    public Task Update<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }
}
