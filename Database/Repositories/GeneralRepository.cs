
using Database.Context;

namespace Database.Repositories;

public class GeneralRepository : IGeneralRepository
{
    ApplicationDbContext _context;
    public GeneralRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Add<T>(T entity) where T : class
    {
        _context.AddAsync(entity);
    }

    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
    }
    public void Delete<T>(T entity) where T : class
    {
        _context.Remove(entity);
    }

    public void DeleteRange<T>(T entity) where T : class
    {
        _context.RemoveRange(entity);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync()) > 0;
    }
}
