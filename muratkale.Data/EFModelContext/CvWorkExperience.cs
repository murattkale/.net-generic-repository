using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Work_Experience")]
    public partial class CvWorkExperience
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [Required]
        [StringLength(50)]
        public string Position { get; set; }
        [Column("Entry_Year")]
        [StringLength(4)]
        public string EntryYear { get; set; }
        [Column("Exit_Year")]
        [StringLength(4)]
        public string ExitYear { get; set; }
    }
}
