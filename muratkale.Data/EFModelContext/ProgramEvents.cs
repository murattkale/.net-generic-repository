using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Program_Events")]
    public partial class ProgramEvents
    {
        public ProgramEvents()
        {
            ProgramsLog = new HashSet<ProgramsLog>();
        }

        [Key]
        [Column("Program_Event_ID")]
        public int ProgramEventId { get; set; }
        [Required]
        [Column("Program_Event")]
        [StringLength(20)]
        public string ProgramEvent { get; set; }

        [InverseProperty("ProgramEvent")]
        public ICollection<ProgramsLog> ProgramsLog { get; set; }
    }
}
