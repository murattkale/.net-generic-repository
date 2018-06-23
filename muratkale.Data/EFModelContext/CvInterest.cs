using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Interest")]
    public partial class CvInterest
    {
        [Key]
        [Column("InterID")]
        public int InterId { get; set; }
        [Required]
        [StringLength(50)]
        public string Interest { get; set; }
    }
}
