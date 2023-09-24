using Microsoft.AspNetCore.Mvc;

namespace Timezone.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
