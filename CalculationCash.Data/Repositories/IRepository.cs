using CalculationCash.Domain;
using System.Linq.Expressions;

namespace CalculationCash.Data
{
    public interface IRepository<TEntity> 
    {
        Task<TEntity> GetById(Guid id);
        Task <IEnumerable<TEntity>> GetAll();
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Guid id);
    }
}
