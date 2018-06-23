using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("TRCCR")]
    public partial class Trccr
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("TR")]
        public int Tr { get; set; }
        [Column("CCR")]
        public int Ccr { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("Trccr")]
        public Student Stu { get; set; }
    }
}
