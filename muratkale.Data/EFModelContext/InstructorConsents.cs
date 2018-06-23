using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Instructor_Consents")]
    public partial class InstructorConsents
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [StringLength(50)]
        public string Section { get; set; }
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        public byte? Consent { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("InstructorConsents")]
        public Student Stu { get; set; }
    }
}
