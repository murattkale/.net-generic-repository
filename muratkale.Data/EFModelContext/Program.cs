using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Program
    {
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Required]
        [Column("Program_Semester")]
        [StringLength(6)]
        public string ProgramSemester { get; set; }
        [Column("Course_Code")]
        [StringLength(20)]
        public string CourseCode { get; set; }
        [Column("ects")]
        public int? Ects { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("Program")]
        public ProgramDepts ProgramNavigation { get; set; }
    }
}
