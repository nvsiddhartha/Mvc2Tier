using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mvc_Svc_Repo_Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task<IList<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
    }
}