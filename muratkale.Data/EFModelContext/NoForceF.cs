using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("No_Force_F")]
    public partial class NoForceF
    {
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Column("Stu_Status")]
        [StringLength(50)]
        public string StuStatus { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("NoForceF")]
        public ProgramDepts Program { get; set; }
    }
}
