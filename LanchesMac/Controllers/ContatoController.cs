using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace LanchesMac.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated) 
            {
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
    }
}
