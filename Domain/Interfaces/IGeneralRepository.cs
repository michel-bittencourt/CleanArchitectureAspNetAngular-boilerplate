namespace Database;

public interface IGeneralRepository
{
    void Add<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    void DeleteRange<T>(T entity) where T : class;

    Task<bool> SaveChangesAsync();
}
