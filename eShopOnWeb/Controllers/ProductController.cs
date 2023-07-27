using Microsoft.AspNetCore.Mvc;

namespace eShopOnWeb.Controllers
{
    /// <summary>
    /// 商品
    /// </summary>
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
