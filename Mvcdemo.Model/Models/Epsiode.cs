using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Epsiode
    {
        public Epsiode()
        {
            ComicPics = new HashSet<ComicPic>();
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            UseRecords = new HashSet<UseRecord>();
        }

        public string EpId { get; set; }
        public string ComicId { get; set; }
        public string EpName { get; set; }
        public int? Click { get; set; }
        public int? EptitlePage { get; set; }
        public string UpdateDate { get; set; }
        public string CheckTypeId { get; set; }
        public string Reason { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual ICollection<ComicPic> ComicPics { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UseRecord> UseRecords { get; set; }
    }
}
