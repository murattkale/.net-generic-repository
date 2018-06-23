using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Score_Types")]
    public partial class ScoreTypes
    {
        [Key]
        [Column("Score_Code")]
        public int ScoreCode { get; set; }
        [Required]
        [Column("Score_name")]
        [StringLength(25)]
        public string ScoreName { get; set; }
    }
}
