using Microsoft.EntityFrameworkCore;

namespace Parking_Lot_Solution.Models
{
	public class ParkingLotDbContext : DbContext
	{
		//public ParkingLotDbContext(DbContextOptions<ParkingLotDbContext> options) : base(options)
		//{

		//}

		//public DbSet<PackingRules> packingRules { get; set; }
		public DbSet<ParkingTickets> parkingTickets { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=SQL5091.site4now.net;Database=db_a483f5_usertest;User Id=db_a483f5_usertest_admin;Password=userTester.1");
		}


		//public class PackingRules
		//{
		//	public int Id { get; set; }
		//	public int EntranceFee { get; set; }
		//	public int FullOrPartialHourCost { get; set; }
		//	public int SuccessiveHourCost { get; set; }
		//}

	}
}
