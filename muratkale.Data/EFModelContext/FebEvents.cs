using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("FEB_Events")]
    public partial class FebEvents
    {
        public FebEvents()
        {
            FebLog = new HashSet<FebLog>();
        }

        [Key]
        [Column("FEB_Event_ID")]
        public int FebEventId { get; set; }
        [Required]
        [Column("FEB_Event")]
        [StringLength(30)]
        public string FebEvent { get; set; }

        [InverseProperty("EventTypeNavigation")]
        public ICollection<FebLog> FebLog { get; set; }
    }
}
