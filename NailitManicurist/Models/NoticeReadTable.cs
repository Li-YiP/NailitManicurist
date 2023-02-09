using System;
using System.Collections.Generic;

#nullable disable

namespace NailitManicurist.Models
{
    public partial class NoticeReadTable
    {
        public int NoticeReadId { get; set; }
        public int NoticeId { get; set; }
        public int NoticeReadMember { get; set; }
        public bool NoticeReadRead { get; set; }
    }
}
