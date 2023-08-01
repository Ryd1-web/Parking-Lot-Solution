using System;
using System.Collections.Generic;

namespace Parking_Lot_Solution.Models
{
    public partial class PackingTicket
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string EntryTime { get; set; } = null!;
        public string ExitTime { get; set; } = null!;
        public int HoursSpent { get; set; }
        public decimal AmountToPay { get; set; }
        public DateTime Date { get; set; }
    }
}
