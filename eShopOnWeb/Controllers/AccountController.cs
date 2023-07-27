using Microsoft.AspNetCore.Mvc;

namespace eShopOnWeb.Controllers
{
    /// <summary>
    /// 帳號
    /// </summary>
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
