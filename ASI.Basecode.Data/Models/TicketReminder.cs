using System;
using System.Collections.Generic;

namespace ASI.Basecode.Data.Models
{
    public partial class TicketReminder
    {
        public Guid Id { get; set; }
        public Guid? TicketId { get; set; }
        public Guid? UserId { get; set; }
        public string Name { get; set; }
        public int? FrequencyType { get; set; }
        public int? Frequency { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}
