using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Personal")]
    public partial class CvPersonal
    {
        [Key]
        [Column("PersonalID")]
        public int PersonalId { get; set; }
        [Required]
        [StringLength(50)]
        public string Personal { get; set; }
    }
}
