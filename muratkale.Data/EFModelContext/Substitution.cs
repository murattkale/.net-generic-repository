using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Substitution
    {
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [StringLength(12)]
        public string Substitute { get; set; }
        public int Priority { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("Substitution")]
        public ProgramDepts Program { get; set; }
    }
}
