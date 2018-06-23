using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Avoid_Maslak")]
    public partial class AvoidMaslak
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
         
        [ForeignKey("StuId")]
        [InverseProperty("AvoidMaslak")]
        public Student Stu { get; set; }
    }
}
