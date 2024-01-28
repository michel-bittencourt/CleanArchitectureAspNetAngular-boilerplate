namespace Database;

public interface IGeneralRepository
{
    Task Add<T>(T entity) where T : class;
    Task Update<T>(T entity) where T : class;
    Task Remove<T>(T entity) where T : class;
}
