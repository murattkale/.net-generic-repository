using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Dept_Consent")]
    public partial class DeptConsent
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [StringLength(50)]
        public string Section { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [StringLength(10)]
        public string DeptHead { get; set; }
        public byte Consent { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("DeptConsent")]
        public Student Stu { get; set; }
    }
}
