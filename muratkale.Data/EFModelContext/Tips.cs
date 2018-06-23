using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Tips
    {
        [Key]
        [Column("TipID")]
        public int TipId { get; set; }
        [Required]
        [Column("Tip_Text")]
        [StringLength(250)]
        public string TipText { get; set; }
    }
}
