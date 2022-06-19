using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class ReportReason
    {
        public ReportReason()
        {
            Reports = new HashSet<Report>();
        }

        public string ReportReasonId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
