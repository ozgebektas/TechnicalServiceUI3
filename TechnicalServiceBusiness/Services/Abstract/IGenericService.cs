using TechnicalServiceCore.Entites;

namespace TechnicalServiceBusiness.Services.Abstract
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<List<T>> TGetAllAsync();
        Task<T> TGetByIdAsync(Guid Id);
        Task<Guid> TUpdateAsync(T entity);
        Task<T> TInsertAsync(T entity);
        void TDelete(T entity);
        Task<int> TSaveAsync();
    }
}
