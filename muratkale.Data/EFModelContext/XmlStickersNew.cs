using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("xmlStickersNew")]
    public partial class XmlStickersNew
    {
        [Key]
        [Column("StickerID")]
        public int StickerId { get; set; }
        [Column("topic")]
        [StringLength(500)]
        public string Topic { get; set; }
        [Column("h1")]
        [StringLength(500)]
        public string H1 { get; set; }
        [Column("title")]
        [StringLength(500)]
        public string Title { get; set; }
        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string StickerNameNonTrChar { get; set; }
    }
}
