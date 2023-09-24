using Microsoft.AspNetCore.Mvc;

namespace Timezone.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
