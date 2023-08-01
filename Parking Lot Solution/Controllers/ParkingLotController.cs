using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parking_Lot_Solution.Models;
using System.Globalization;

namespace Parking_Lot_Solution.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ParkingLotController : Controller
	{
		private readonly db_a483f5_usertestContext _context;

		public ParkingLotController(db_a483f5_usertestContext context)
		{
			_context = context;
		}


		[HttpPost]
		[Route("CalculateParkingCost")]
		public IActionResult CalculateParkingCost(string timeOfEntry, string timeOfExit)
		{
			DateTime entryTime = DateTime.ParseExact(timeOfEntry, "HH:mm", CultureInfo.InvariantCulture);
			DateTime exitTime = DateTime.ParseExact(timeOfExit, "HH:mm", CultureInfo.InvariantCulture);

			int totalCost = ParkingCostImplementation.GetParkingCost(entryTime, exitTime);

			ParkingTicket ticket = new ParkingTicket
			{
				EntryTime = entryTime,
				ExitTime = exitTime,
				TotalCost = totalCost
			};

			_context.ParkingTickets.Add(ticket);
			_context.SaveChanges();

			return Ok(totalCost);
		}

		[HttpGet]
		[Route("GetDateTickets")]
		public IActionResult GetDateTickets(string date)
		{
			DateTime dateInput = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);

			var tickets = _context.ParkingTickets.Where(p => p.EntryTime.Date == dateInput).ToList();

			return Ok(tickets);
		}
	}
}
