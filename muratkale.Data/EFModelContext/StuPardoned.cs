using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Pardoned")]
    public partial class StuPardoned
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }
        public bool? Active { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StuPardoned")]
        public Student Stu { get; set; }
    }
}
