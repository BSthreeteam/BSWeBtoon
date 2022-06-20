using System;

namespace BSWeBtoon.Front.Models
{
    public class Recharge
    {
        public string RechargeId { get; set; }
        public string MemberId { get; set; }
        public string CoinId { get; set; }
        public DateTime RechargeDate { get; set; }
        public string PayMethod { get; set; }
    }
}
