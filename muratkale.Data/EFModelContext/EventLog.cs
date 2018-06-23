using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Event_Log")]
    public partial class EventLog
    {
        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(11)]
        public string UserId { get; set; }
        [Column("Event_Type")]
        public int EventType { get; set; }
        [Column("Event_Desc", TypeName = "ntext")]
        public string EventDesc { get; set; }
        [Column("Event_Time", TypeName = "datetime")]
        public DateTime EventTime { get; set; }

        [ForeignKey("EventType")]
        [InverseProperty("EventLog")]
        public EventTypes EventTypeNavigation { get; set; }
    }
}
