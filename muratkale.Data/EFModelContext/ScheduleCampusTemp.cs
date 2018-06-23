using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Schedule_Campus_Temp")]
    public partial class ScheduleCampusTemp
    {
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Required]
        [StringLength(10)]
        public string Campus { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("ScheduleCampusTemp")]
        public Course CourseCodeNavigation { get; set; }
    }
}
