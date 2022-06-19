using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class UseRecord
    {
        public string UseRecordId { get; set; }
        public string MemberId { get; set; }
        public string EpId { get; set; }
        public string StockId { get; set; }
        public DateTime? UseDateSart { get; set; }
        public DateTime? UseDateEnd { get; set; }
        public int? Quantity { get; set; }

        public virtual Epsiode Ep { get; set; }
        public virtual Member Member { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
