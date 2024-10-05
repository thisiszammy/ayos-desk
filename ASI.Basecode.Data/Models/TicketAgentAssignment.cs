using System;
using System.Collections.Generic;

namespace ASI.Basecode.Data.Models
{
    public partial class TicketAgentAssignment
    {
        public Guid Id { get; set; }
        public Guid? TicketId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? AssignedOn { get; set; }
        public Guid? AssignedBy { get; set; }
        public DateTime? RemovedOn { get; set; }
        public Guid? RemovedBy { get; set; }
    }
}
