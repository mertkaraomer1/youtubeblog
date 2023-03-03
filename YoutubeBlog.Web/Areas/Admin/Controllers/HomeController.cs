using Microsoft.AspNetCore.Mvc;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
