using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Lang")]
    public partial class CvLang
    {
        [Key]
        [Column("LangID")]
        public int LangId { get; set; }
        [Required]
        [StringLength(20)]
        public string Language { get; set; }
    }
}
