using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class PayMethod
    {
        public PayMethod()
        {
            Recharges = new HashSet<Recharge>();
        }

        public string PayMethodId { get; set; }
        public string PayMethodName { get; set; }
        public string PayMethodtype { get; set; }

        public virtual ICollection<Recharge> Recharges { get; set; }
    }
}
