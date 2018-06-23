using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Class_Credits")]
    public partial class ClassCredits
    {
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("Program_Semester")]
        public byte ProgramSemester { get; set; }
        [Column("Credits_so_far")]
        public byte CreditsSoFar { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("ClassCredits")]
        public ProgramDepts Program { get; set; }
    }
}
