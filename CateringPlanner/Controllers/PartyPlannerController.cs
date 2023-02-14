using CateringPlanner.Data;
using CateringPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CateringPlanner.Controllers
{
	public class PartyPlannerController : Controller
	{
        private readonly ApplicationDbContext _context;

        public PartyPlannerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> Post([Bind("Id,FirstName,LastName,StreetAddress,City,State,ZipCode,PhoneNumber,Email")] Customer customer)
		{
            if (ModelState.IsValid)
			{
				_context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

	}
}
