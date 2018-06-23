using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("High_Schools")]
    public partial class HighSchools
    {
        [Key]
        [Column("schoolid")]
        public int Schoolid { get; set; }
        [Required]
        [Column("school_code")]
        [StringLength(50)]
        public string SchoolCode { get; set; }
        [Required]
        [Column("school_name")]
        [StringLength(50)]
        public string SchoolName { get; set; }
    }
}
