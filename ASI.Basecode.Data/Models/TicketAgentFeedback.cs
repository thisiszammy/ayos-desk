using System;
using System.Collections.Generic;

namespace ASI.Basecode.Data.Models
{
    public partial class TicketAgentFeedback
    {
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public Guid? AgentId { get; set; }
        public int? Criteria { get; set; }
        public int? Rating { get; set; }
        public string Remarks { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
