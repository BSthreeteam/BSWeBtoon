using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
            Recharges = new HashSet<Recharge>();
            ReportBeReportedMembers = new HashSet<Report>();
            ReportReportMembers = new HashSet<Report>();
            Stocks = new HashSet<Stock>();
            UseRecords = new HashSet<UseRecord>();
        }

        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public decimal? CoinQuantity { get; set; }
        public string LoginTypeId { get; set; }
        public string Setting { get; set; }

        public virtual LoginType LoginType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Recharge> Recharges { get; set; }
        public virtual ICollection<Report> ReportBeReportedMembers { get; set; }
        public virtual ICollection<Report> ReportReportMembers { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<UseRecord> UseRecords { get; set; }
    }
}
