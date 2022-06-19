using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Coin
    {
        public Coin()
        {
            Recharges = new HashSet<Recharge>();
        }

        public string CoinId { get; set; }
        public string CoinName { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual ICollection<Recharge> Recharges { get; set; }
    }
}
