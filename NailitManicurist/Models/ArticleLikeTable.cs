﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NailitManicurist.Models
{
    public partial class ArticleLikeTable
    {
        public int ArticleLikeId { get; set; }
        public int ArticleId { get; set; }
        public int MemberId { get; set; }
    }
}
