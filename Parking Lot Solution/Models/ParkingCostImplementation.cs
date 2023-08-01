namespace Parking_Lot_Solution.Models
{
	public static class ParkingCostImplementation
	{
		public static int GetParkingCost (DateTime entryTime, DateTime exitTime)
		{
			int entranceFee	= 2;
			int fullOrPartialHourCost = 3;
			int successiveHourCost = 4;

			TimeSpan Duration = exitTime - entryTime;
			int totalCost = fullOrPartialHourCost + entranceFee;

			if(Duration.TotalHours > 1)
			{
				//Calculate the total number of full or partial hours beyond the first hour
				int additionalHours = (int)(Duration.TotalHours - 1);
				if (Duration.TotalHours > additionalHours + 1)
				{
					additionalHours += 1;
				}
				//Calculate the cost for the additional hours based on the successiveHourCost
				int additionalHoursCost = successiveHourCost * additionalHours;
				totalCost += additionalHoursCost;

			}

			return totalCost;
		}
	}
}
