using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("FEB_Log")]
    public partial class FebLog
    {
        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }
        [Column("Event_Type")]
        public int EventType { get; set; }
        [Column("Event_Desc", TypeName = "ntext")]
        public string EventDesc { get; set; }
        [Column("Event_Time", TypeName = "datetime")]
        public DateTime EventTime { get; set; }
        [Column("FEB_Number")]
        public int FebNumber { get; set; }
        [Required]
        [Column("FEB_Date", TypeName = "char(30)")]
        public string FebDate { get; set; }

        [ForeignKey("EventType")]
        [InverseProperty("FebLog")]
        public FebEvents EventTypeNavigation { get; set; }
    }
}
