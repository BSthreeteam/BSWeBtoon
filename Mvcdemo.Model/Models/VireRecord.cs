using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class VireRecord
    {
        public string EpId { get; set; }
        public string MemberId { get; set; }
        public string ComicId { get; set; }
        public string PeoplePic { get; set; }
        public string BgPic { get; set; }
        public string ComicPicId { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual ComicPic ComicPic { get; set; }
        public virtual Epsiode Ep { get; set; }
        public virtual Member Member { get; set; }
    }
}
