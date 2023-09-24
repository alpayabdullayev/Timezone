using Microsoft.AspNetCore.Mvc;

namespace Timezone.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
