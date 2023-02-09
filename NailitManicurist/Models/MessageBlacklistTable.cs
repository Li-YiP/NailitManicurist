using System;
using System.Collections.Generic;

#nullable disable

namespace NailitManicurist.Models
{
    public partial class MessageBlacklistTable
    {
        public int BlacklistId { get; set; }
        public int BlacklistBuilder { get; set; }
        public int BlacklistTarget { get; set; }
    }
}
