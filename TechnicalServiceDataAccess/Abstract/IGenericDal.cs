using System.Linq.Expressions;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceDataAccess.Abstract
{
    public interface IGenericDal<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
