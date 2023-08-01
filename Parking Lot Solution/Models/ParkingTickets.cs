namespace Parking_Lot_Solution.Models
{
	public class ParkingTickets
	{
		public int Id { get; set; }
		public DateTime EntryTime { get; set; }
		public DateTime ExitTime { get; set; }
		public int TotalCost { get; set; }
	}
}
