using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("stu_msb_info")]
    public partial class StuMsbInfo
    {
        [Column("city")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("msb", TypeName = "nchar(50)")]
        public string Msb { get; set; }
    }
}
