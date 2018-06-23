using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Prevent_Delete")]
    public partial class PreventDelete
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("PreventDelete")]
        public Student Stu { get; set; }
    }
}
