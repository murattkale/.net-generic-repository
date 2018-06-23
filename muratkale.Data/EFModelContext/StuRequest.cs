using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Request")]
    public partial class StuRequest
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("ReqID")]
        public int ReqId { get; set; }
        public byte Number { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }

        [ForeignKey("ReqId")]
        [InverseProperty("StuRequest")]
        public RequestTypes Req { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("StuRequest")]
        public Student Stu { get; set; }
    }
}
