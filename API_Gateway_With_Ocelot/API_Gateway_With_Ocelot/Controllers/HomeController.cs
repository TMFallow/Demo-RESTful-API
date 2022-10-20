using Microsoft.AspNetCore.Mvc;

namespace API_Gateway_With_Ocelot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
