using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Stock
    {
        public Stock()
        {
            UseRecords = new HashSet<UseRecord>();
        }

        public string StockId { get; set; }
        public string MemberId { get; set; }
        public string ComicId { get; set; }
        public int? StockQuantity { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<UseRecord> UseRecords { get; set; }
    }
}
