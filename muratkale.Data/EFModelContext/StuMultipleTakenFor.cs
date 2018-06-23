using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Multiple_Taken_For")]
    public partial class StuMultipleTakenFor
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column("Taken_For")]
        [StringLength(15)]
        public string TakenFor { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("StuMultipleTakenFor")]
        public Course CourseCodeNavigation { get; set; }
    }
}
