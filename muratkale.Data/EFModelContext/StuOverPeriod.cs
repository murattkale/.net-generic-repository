using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Over_Period")]
    public partial class StuOverPeriod
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StuOverPeriod")]
        public Student Stu { get; set; }
    }
}
