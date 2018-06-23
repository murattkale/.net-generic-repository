using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Stu_Personal")]
    public partial class CvStuPersonal
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("PersonalID")]
        public int PersonalId { get; set; }
    }
}
