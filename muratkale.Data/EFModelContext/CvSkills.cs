using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("CV_Skills")]
    public partial class CvSkills
    {
        [Key]
        [Column("SkillID")]
        public int SkillId { get; set; }
        [Required]
        [StringLength(50)]
        public string Skill { get; set; }
    }
}
