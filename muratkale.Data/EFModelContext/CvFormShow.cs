using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Form_Show")]
    public partial class CvFormShow
    {
        [Key]
        [Column("StuID")]
        [StringLength(13)]
        public string StuId { get; set; }
    }
}
