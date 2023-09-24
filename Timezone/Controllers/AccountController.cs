using Microsoft.AspNetCore.Mvc;

namespace Timezone.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
