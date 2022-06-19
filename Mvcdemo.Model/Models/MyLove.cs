using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class MyLove
    {
        public string MemberId { get; set; }
        public string ComicId { get; set; }
        public string NamePic { get; set; }
        public string PeoplePic { get; set; }
        public string BgcPic { get; set; }
        public string Bell { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Member Member { get; set; }
    }
}
