using Microsoft.EntityFrameworkCore;
using Mvc_Svc_Repo_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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

        public async Task<IList<TEntity>> GetAll()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync();
        }

        public async Task<IList<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await Context.Set<TEntity>().Where(expression).ToListAsync();
        }
    }
}
