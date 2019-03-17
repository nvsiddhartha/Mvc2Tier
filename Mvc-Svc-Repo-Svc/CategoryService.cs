using Mvc_Svc_Repo_Data;
using Mvc_Svc_Repo_Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mvc_Svc_Repo_Svc
{
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _repo { get; set; }

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public async Task<IList<Categories>> GetCategoriesAsync()
        {
           return await _repo.GetAll();
        }
    }
} 
