using System;
using System.Collections.Generic;

namespace ASI.Basecode.Data.Models
{
    public partial class TicketAttachment
    {
        public Guid Id { get; set; }
        public Guid? TicketId { get; set; }
        public int? AttachmentType { get; set; }
        public string Source { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}
