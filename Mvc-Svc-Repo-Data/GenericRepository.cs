using Microsoft.EntityFrameworkCore;
using Mvc_Svc_Repo_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mvc_Svc_Repo_Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public NorthwindContext Context { get; set; }

        public GenericRepository(NorthwindContext ctx)
        {
            Context = ctx;
        }

        public async Task<IList<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();

            if (includes != null)
            {
                foreach (Expression<Func<TEntity, object>> include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.ToListAsync();
        }
        
        public async Task<IList<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await Context.Set<TEntity>().Where(expression).ToListAsync();
        }
    }
}
