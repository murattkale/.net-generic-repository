using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Schedule_Owner")]
    public partial class ScheduleOwner
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Required]
        [Column(TypeName = "char(10)")]
        public string Owner { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("ScheduleOwner")]
        public Course CourseCodeNavigation { get; set; }
    }
}
