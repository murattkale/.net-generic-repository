using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Semester_Loads")]
    public partial class SemesterLoads
    {
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("Program_Semester")]
        [StringLength(6)]
        public string ProgramSemester { get; set; }
        [Column("Semester_Load")]
        public int SemesterLoad { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("SemesterLoads")]
        public ProgramDepts Program { get; set; }
    }
}
