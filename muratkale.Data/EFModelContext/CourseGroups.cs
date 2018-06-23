using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Course_Groups")]
    public partial class CourseGroups
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("GroupID", TypeName = "nchar(2)")]
        public string GroupId { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("CourseGroups")]
        public Course CourseCodeNavigation { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("CourseGroups")]
        public ProgramDepts Program { get; set; }
    }
}
