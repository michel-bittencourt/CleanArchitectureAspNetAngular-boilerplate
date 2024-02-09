using Application.DTOs;

namespace Application.Interfaces;

public interface IGeneralService
{
    Task Add<T>(T entityDTO) where T : class;
    Task Update<T>(T entityDTO) where T : class;
    Task Delete(int? id);
    //Task DeleteRange<T>(T[] entityDTO) where T : class;
}
