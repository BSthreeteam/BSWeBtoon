using System;
using System.Collections.Generic;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class LoginType
    {
        public LoginType()
        {
            Members = new HashSet<Member>();
        }

        public string LoginTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
