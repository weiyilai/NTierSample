using Microsoft.AspNetCore.Mvc;

namespace eShopOnWeb.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
