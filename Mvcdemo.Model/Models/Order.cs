using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Order
    {
        public string OrderId { get; set; }
        public string MemberId { get; set; }
        public string GetId { get; set; }
        public string EpId { get; set; }
        public string StockId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? StockQuantity { get; set; }

        public virtual Epsiode Ep { get; set; }
        public virtual Member Member { get; set; }
    }
}
