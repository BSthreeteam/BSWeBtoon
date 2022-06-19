using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class ComicPic
    {
        public string ComicPicId { get; set; }
        public string EpId { get; set; }
        public string ComicId { get; set; }
        public string Jpg { get; set; }
        public int? Sort { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Epsiode Ep { get; set; }
    }
}
