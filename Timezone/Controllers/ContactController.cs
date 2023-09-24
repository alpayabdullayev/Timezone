using Microsoft.AspNetCore.Mvc;

namespace Timezone.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
