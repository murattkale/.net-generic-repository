using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("StickerInsertAPI")]
    public partial class StickerInsertApi
    {
        [Column("StickerInsertAPIID")]
        public int StickerInsertApiid { get; set; }
        public bool? Status { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
        [Column("StickerID")]
        public int? StickerId { get; set; }
        [Column("page")]
        public int? Page { get; set; }
    }
}
