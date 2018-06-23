using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Final_GPA")]
    public partial class FinalGpa
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Program_GPA")]
        public double ProgramGpa { get; set; }
        [Column("Overall_GPA")]
        public double OverallGpa { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("FinalGpa")]
        public Student Stu { get; set; }
    }
}
