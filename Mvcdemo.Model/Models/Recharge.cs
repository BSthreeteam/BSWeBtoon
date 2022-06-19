using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Recharge
    {
        public string RechargeId { get; set; }
        public string MemberId { get; set; }
        public string CoinId { get; set; }
        public DateTime? RechargeDate { get; set; }
        public string PayMethodId { get; set; }

        public virtual Coin Coin { get; set; }
        public virtual Member Member { get; set; }
        public virtual PayMethod PayMethod { get; set; }
    }
}
