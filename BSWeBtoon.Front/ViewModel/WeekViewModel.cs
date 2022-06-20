using Mvcdemo.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSWeBtoon.Front.ViewModel
{
    public class WeekViewModel
    {
        public string ComicId { get; set; }

        public string ComicName { get; set; }
        public string NamePic { get; set; }
        public string BgPic { get; set; }
        public string PeoplePic { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string Introduction { get; set; }
        public string ComicStatusId { get; set; }
        public virtual ComicStatus ComicStatus { get; set; }


    }
}
