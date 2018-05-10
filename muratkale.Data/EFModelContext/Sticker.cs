using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Sticker
    {
        [Column("StickerID")]
        public int StickerId { get; set; }
        [Required]
        [StringLength(500)]
        public string StickerName { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSiteWideDisabled { get; set; }
        public bool? UserSticker { get; set; }
        public bool? AdminSticker { get; set; }
        [StringLength(500)]
        public string StickerNameNonTrChar { get; set; }
        public bool IsChecked { get; set; }
        [StringLength(500)]
        public string ClickLink { get; set; }
        [Column("AdminID")]
        public int? AdminId { get; set; }
        public bool GoogleS { get; set; }
        public bool BingS { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
    }
}
