using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Programs_Log")]
    public partial class ProgramsLog
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Prog_Status", TypeName = "char(2)")]
        public string ProgStatus { get; set; }
        [Required]
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("Program_Event_Date", TypeName = "datetime")]
        public DateTime ProgramEventDate { get; set; }
        [Column("Program_Event_ID")]
        public int ProgramEventId { get; set; }

        [ForeignKey("ProgramEventId")]
        [InverseProperty("ProgramsLog")]
        public ProgramEvents ProgramEvent { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("ProgramsLog")]
        public Student Stu { get; set; }
    }
}
