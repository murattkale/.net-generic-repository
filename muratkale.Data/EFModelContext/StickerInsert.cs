using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class StickerInsert
    {
        [Column("StickerInsertID")]
        public int StickerInsertId { get; set; }
        public bool? Status { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
        [Column("ArticleID")]
        public int? ArticleId { get; set; }
        [Column("StickerID")]
        public int? StickerId { get; set; }
    }
}
