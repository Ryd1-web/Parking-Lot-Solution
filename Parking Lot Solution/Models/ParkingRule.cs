using System;
using System.Collections.Generic;

namespace Parking_Lot_Solution.Models
{
    public partial class ParkingRule
    {
        public int Id { get; set; }
        public int EntranceFee { get; set; }
        public int FirstHourCost { get; set; }
        public int SuccessiveHourCost { get; set; }
    }
}
