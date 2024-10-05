using System;
using System.Collections.Generic;

namespace ASI.Basecode.Data.Models
{
    public partial class ArticleTag
    {
        public Guid ArticleId { get; set; }
        public string Tag { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}
