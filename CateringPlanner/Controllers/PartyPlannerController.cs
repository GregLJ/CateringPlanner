using Microsoft.AspNetCore.Mvc;

namespace CateringPlanner.Controllers
{
	public class PartyPlannerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
