using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("All_Programs")]
    public partial class AllPrograms
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [StringLength(2)]
        public string Section { get; set; }
        [Column(TypeName = "char(1)")]
        public string Origin { get; set; }
        [Column(TypeName = "char(2)")]
        public string Status { get; set; }
        [Column("Taken_For")]
        [StringLength(20)]
        public string TakenFor { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("AllPrograms")]
        public Course CourseCodeNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("AllPrograms")]
        public Student Stu { get; set; }
    }
}
