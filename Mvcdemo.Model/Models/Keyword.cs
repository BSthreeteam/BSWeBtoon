using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Keyword
    {
        public string KeywordDetailId { get; set; }
        public string ComicId { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual KeywordDetail KeywordDetail { get; set; }
    }
}
