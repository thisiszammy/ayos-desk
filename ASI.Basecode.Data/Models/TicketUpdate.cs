using System;
using System.Collections.Generic;

namespace ASI.Basecode.Data.Models
{
    public partial class TicketUpdate
    {
        public Guid Id { get; set; }
        public Guid? TicketId { get; set; }
        public int? Status { get; set; }
        public int? Priority { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
