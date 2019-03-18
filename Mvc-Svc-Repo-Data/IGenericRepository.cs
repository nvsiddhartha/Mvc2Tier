using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mvc_Svc_Repo_Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] includes);

        Task<IList<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
    }
}