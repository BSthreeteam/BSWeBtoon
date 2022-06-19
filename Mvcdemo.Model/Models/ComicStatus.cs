using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class ComicStatus
    {
        public ComicStatus()
        {
            Comics = new HashSet<Comic>();
        }

        public string ComicStatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Comic> Comics { get; set; }
    }
}
