using Microsoft.AspNetCore.Mvc;

namespace eShopOnWeb.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
