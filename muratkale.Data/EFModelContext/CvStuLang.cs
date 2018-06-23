using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Stu_Lang")]
    public partial class CvStuLang
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("LangID")]
        public int LangId { get; set; }
        [Required]
        [StringLength(20)]
        public string Level { get; set; }
    }
}
