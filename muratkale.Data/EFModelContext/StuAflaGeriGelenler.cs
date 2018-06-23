using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_AflaGeriGelenler")]
    public partial class StuAflaGeriGelenler
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DropDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
    }
}
