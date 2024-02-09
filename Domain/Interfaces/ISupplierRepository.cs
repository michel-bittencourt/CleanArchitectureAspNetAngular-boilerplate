using Domain.Entities;

namespace Domain.Interfaces;

public interface ISupplierRepository : IGeneralRepository
{
    Task<IEnumerable<Supplier>> GetSuppliersAsync(Supplier supplier);
    Task<Supplier> GetSupplierByIdAsync(int? id);
}
