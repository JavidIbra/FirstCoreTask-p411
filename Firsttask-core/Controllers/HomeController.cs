using Microsoft.AspNetCore.Mvc;

namespace Firsttask_core.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {

            return View();
        }

   
    }
}
