using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class ComicCheckType
    {
        public ComicCheckType()
        {
            Comics = new HashSet<Comic>();
        }

        public string ComicCheckTypeId { get; set; }
        public string ComicCheckTypeName { get; set; }

        public virtual ICollection<Comic> Comics { get; set; }
    }
}
