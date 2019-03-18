using Mvc_Svc_Repo_Data.Models;
using System.Threading.Tasks;

namespace Mvc_Svc_Repo_Data
{
    public interface ICategoryRepository : IGenericRepository<Categories>
    {
        Task<Categories> GetById(int id);
    }
}