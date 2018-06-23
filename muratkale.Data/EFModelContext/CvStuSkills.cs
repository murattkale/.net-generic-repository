using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Stu_Skills")]
    public partial class CvStuSkills
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("SkillID")]
        public int SkillId { get; set; }
    }
}
