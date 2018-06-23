using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Announcements
    {
        [Key]
        [Column("AnnID")]
        public int AnnId { get; set; }
        [Required]
        [Column(TypeName = "char(11)")]
        public string Concern { get; set; }
        [Required]
        [Column("Ann_Text", TypeName = "text")]
        public string AnnText { get; set; }
        [Column("Msg_From")]
        [StringLength(11)]
        public string MsgFrom { get; set; }
        [Column("Msg_Date", TypeName = "datetime")]
        public DateTime? MsgDate { get; set; }
        [Column("Msg_Type")]
        [StringLength(50)]
        public string MsgType { get; set; }
    }
}
