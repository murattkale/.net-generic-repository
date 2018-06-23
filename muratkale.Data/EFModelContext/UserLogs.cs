using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("User_Logs")]
    public partial class UserLogs
    {
        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }
        [Column("Event_Time", TypeName = "datetime")]
        public DateTime? EventTime { get; set; }
        [Column("Event_Type")]
        public int? EventType { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

        [ForeignKey("EventType")]
        [InverseProperty("UserLogs")]
        public EventTypes EventTypeNavigation { get; set; }
    }
}
