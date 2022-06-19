using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class GetMethod
    {
        public string GetMethodId { get; set; }
        public string GetMethodName { get; set; }
        public DateTime? GetMethodStartDate { get; set; }
        public DateTime? GetMethodEndDate { get; set; }
        public string ComicId { get; set; }

        public virtual Comic Comic { get; set; }
    }
}
