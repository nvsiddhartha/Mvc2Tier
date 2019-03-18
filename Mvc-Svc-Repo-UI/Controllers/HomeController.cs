using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_Svc_Repo_Svc;
using Mvc_Svc_Repo_UI.Models;

namespace Mvc_Svc_Repo_UI.Controllers
{
    public class HomeController : Controller
    {
        public ICategoryService CategorySvc { get; set; }

        public HomeController(ICategoryService svc)
        {
            CategorySvc = svc;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Categories = await CategorySvc.GetCategoriesAsync();

            ViewBag.Categories2 = await CategorySvc.GetCategoriesIncludeAsync();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
