using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_On_Leave")]
    public partial class StuOnLeave
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public int Year { get; set; }
        [StringLength(6)]
        public string Semester { get; set; }
        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StuOnLeave")]
        public Student Stu { get; set; }
    }
}
