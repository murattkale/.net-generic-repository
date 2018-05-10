using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class StickerVaryant
    {
        [Column("StickerVaryantID")]
        public int StickerVaryantId { get; set; }
        [Column("StickerID")]
        public int? StickerId { get; set; }
        [StringLength(100)]
        public string VaryantName { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(100)]
        public string VaryantUrl { get; set; }
    }
}
