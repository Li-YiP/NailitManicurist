using System;
using System.Collections.Generic;

#nullable disable

namespace NailitManicurist.Models
{
    public partial class PlanTable
    {
        public int PlanId { get; set; }
        public int ManicuristId { get; set; }
        public DateTime PlanStartTime { get; set; }
        public int? OrderId { get; set; }
        public string PlanRemark { get; set; }
    }
}
