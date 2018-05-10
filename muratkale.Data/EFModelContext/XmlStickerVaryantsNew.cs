using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("xmlStickerVaryantsNew")]
    public partial class XmlStickerVaryantsNew
    {
        [Key]
        [Column("VaryantID")]
        public int VaryantId { get; set; }
        [Column("StickerID")]
        public int? StickerId { get; set; }
        [StringLength(500)]
        public string VaryantName { get; set; }
        [StringLength(500)]
        public string VaryantUrl { get; set; }
    }
}
