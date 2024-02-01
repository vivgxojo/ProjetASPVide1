using Microsoft.AspNetCore.Mvc;

namespace ProjetASPVide1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Bonjour");
        }

        public IActionResult AfficherParmetre(string id)
        {
            return Content("Le paramètre est : " + id);
        }

        public IActionResult AfficherVue() {
            return View("Vue");
        }

        public IActionResult EnvoyerDonneVue()
        {
            string data = "lkaj;dfjkla";
            string data2 = "donnée 2";
            ViewData["data"] = data;
            ViewBag.data2 = data2;
            return View("VueDonne");
        }
    }
}
