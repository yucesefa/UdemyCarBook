using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Controllers
{
	public class TestimonialController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.v1 = "Hizmetler";
			ViewBag.v2 = "Hizmetlerimiz";
			return View();
		}
	}
}
