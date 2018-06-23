using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class IntibakAgreed
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ApproveDate { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("IntibakAgreed")]
        public Student Stu { get; set; }
    }
}
