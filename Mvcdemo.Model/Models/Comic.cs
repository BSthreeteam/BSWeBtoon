using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class Comic
    {
        public Comic()
        {
            ComicPics = new HashSet<ComicPic>();
            Comments = new HashSet<Comment>();
            Epsiodes = new HashSet<Epsiode>();
            GetMethods = new HashSet<GetMethod>();
            Stocks = new HashSet<Stock>();
        }

        public string ComicId { get; set; }
        public string ComicName { get; set; }
        public string NamePic { get; set; }
        public string BgPic { get; set; }
        public string PeoplePic { get; set; }
        public string Bgc { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string UpdateWeek { get; set; }
        public string Publisher { get; set; }
        public string Introduction { get; set; }
        public string ComicStatusId { get; set; }
        public string AppleVideoLong { get; set; }
        public string VideoLong { get; set; }
        public string AppleVideoShort { get; set; }
        public string VideoShort { get; set; }
        public string Author { get; set; }
        public string ComicCheckType { get; set; }
        public int? Rank { get; set; }
        public string Reason { get; set; }

        public virtual ComicCheckType ComicCheckTypeNavigation { get; set; }
        public virtual ComicStatus ComicStatus { get; set; }
        public virtual ICollection<ComicPic> ComicPics { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Epsiode> Epsiodes { get; set; }
        public virtual ICollection<GetMethod> GetMethods { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
