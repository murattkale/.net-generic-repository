using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Event_Types")]
    public partial class EventTypes
    {
        public EventTypes()
        {
            EventLog = new HashSet<EventLog>();
            UserLogs = new HashSet<UserLogs>();
        }

        [Key]
        [Column("Event_Type")]
        public int EventType { get; set; }
        [Required]
        [Column("Event_Desc")]
        [StringLength(50)]
        public string EventDesc { get; set; }

        [InverseProperty("EventTypeNavigation")]
        public ICollection<EventLog> EventLog { get; set; }
        [InverseProperty("EventTypeNavigation")]
        public ICollection<UserLogs> UserLogs { get; set; }
    }
}
