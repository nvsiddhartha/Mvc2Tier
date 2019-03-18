using System.Collections.Generic;
using System.Threading.Tasks;
using Mvc_Svc_Repo_Data;
using Mvc_Svc_Repo_Data.Models;

namespace Mvc_Svc_Repo_Svc
{
    public interface ICategoryService
    {
        Task<IList<Categories>> GetCategoriesAsync();

        Task<IList<Categories>> GetCategoriesIncludeAsync();

        Task<Categories> GetCategoryByIdAsync(int id);
    }
}