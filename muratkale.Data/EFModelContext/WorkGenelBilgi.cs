using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("work_genel_bilgi")]
    public partial class WorkGenelBilgi
    {
        [Key]
        [Column("stuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("tasinmaz")]
        [StringLength(10)]
        public string Tasinmaz { get; set; }
        [Column("tasit")]
        [StringLength(10)]
        public string Tasit { get; set; }
        [Column("stu_tasit")]
        [StringLength(10)]
        public string StuTasit { get; set; }
    }
}
