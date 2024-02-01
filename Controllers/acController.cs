using Microsoft.AspNetCore.Mvc;

namespace ProjetASPVide1.Controllers
{
	public class acController : Controller
	{
		public IActionResult Index(string p1, string p2)
		{
			return Content("Les paramètres : " + p1+ " et " + p2);
		}
	}
}
