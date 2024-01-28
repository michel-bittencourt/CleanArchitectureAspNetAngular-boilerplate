namespace Application.Interfaces;

public interface IGeneralService
{
    Task Add<T>(T entityDTO) where T : class;
    Task Update<T>(T entityDTO) where T : class;
    Task Delete<T>(T entityDTO) where T : class;
    Task DeleteRange<T>(T[] entityDTO) where T : class;

    Task<bool> SaveChangesAsync();
}
