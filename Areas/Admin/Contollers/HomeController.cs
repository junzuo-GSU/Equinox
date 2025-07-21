using Microsoft.AspNetCore.Mvc;

namespace Equinox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {   
       //Below attribute routing is wrong. It can also use more simplified version. Know how?
        [Route("Admin")]
        [Route("Admin/Home")]
        [Route("Admin/Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
