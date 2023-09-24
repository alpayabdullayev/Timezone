using Microsoft.AspNetCore.Mvc;

namespace Timezone.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
