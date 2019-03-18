using Microsoft.EntityFrameworkCore;
using Mvc_Svc_Repo_Data.Models;
using System.Threading.Tasks;

namespace Mvc_Svc_Repo_Data
{
    public class CategoryRepository : GenericRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext ctx) : base(ctx) { }

        public async Task<Categories> GetById(int id)
        {
            return await Context.Categories
                .Include(i => i.Products)
                .FirstOrDefaultAsync(i => i.CategoryId == id);
        }
    }
}
