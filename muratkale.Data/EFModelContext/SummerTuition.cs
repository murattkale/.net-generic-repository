using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Summer_Tuition")]
    public partial class SummerTuition
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Total_Courses")]
        public int TotalCourses { get; set; }
        [Column("Selected_Courses")]
        public int? SelectedCourses { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("SummerTuition")]
        public Student Stu { get; set; }
    }
}
