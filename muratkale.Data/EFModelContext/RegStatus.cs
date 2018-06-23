using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Reg_Status")]
    public partial class RegStatus
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("StatusID")]
        public byte StatusId { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("RegStatus")]
        public StatusValues Status { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("RegStatus")]
        public Student Stu { get; set; }
    }
}
