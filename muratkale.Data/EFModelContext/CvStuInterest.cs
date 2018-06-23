using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Stu_Interest")]
    public partial class CvStuInterest
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("InterID")]
        public int InterId { get; set; }
    }
}
