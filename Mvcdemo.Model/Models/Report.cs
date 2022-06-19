using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Report
    {
        public string ReportId { get; set; }
        public string CommentId { get; set; }
        public string BeReportedMemberId { get; set; }
        public string ReportMemberId { get; set; }
        public string ReportReasonId { get; set; }

        public virtual Member BeReportedMember { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual Member ReportMember { get; set; }
        public virtual ReportReason ReportReason { get; set; }
    }
}
