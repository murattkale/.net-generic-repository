using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class News
    {
        [Column("NewsID")]
        public int NewsId { get; set; }
        [Required]
        [Column("News_Text")]
        [StringLength(250)]
        public string NewsText { get; set; }
    }
}
