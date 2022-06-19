using System;

namespace BSWeBtoon.Front.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string MemberId { get; set; }
        public string GetId { get; set; }
        public string EpId { get; set; }
        public string StockId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public int StockQuantity { get; set; }
    }
}
