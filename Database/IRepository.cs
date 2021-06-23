using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        Task<List<TEntity>> Get();
        Task<TEntity> GetBy(Expression<Func<TEntity, bool>> exp);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
