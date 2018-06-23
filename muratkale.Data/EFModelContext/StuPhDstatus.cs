using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_PhDStatus")]
    public partial class StuPhDstatus
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("StatusID")]
        public int StatusId { get; set; }
        [Column("insertdatetime", TypeName = "datetime")]
        public DateTime Insertdatetime { get; set; }
    }
}
