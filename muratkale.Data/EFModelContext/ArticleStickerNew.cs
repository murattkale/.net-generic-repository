using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class ArticleStickerNew
    {
        [Key]
        [Column("ArticleStickerID")]
        public int ArticleStickerId { get; set; }
        [Column("ArticleID")]
        public int ArticleId { get; set; }
        [Column("StickerID")]
        public int StickerId { get; set; }
        public int? StickerIndexDetay { get; set; }
        public int? StickerIndexSpot { get; set; }
        public int? StickerIndexText { get; set; }
        public bool? IsReady { get; set; }
    }
}
