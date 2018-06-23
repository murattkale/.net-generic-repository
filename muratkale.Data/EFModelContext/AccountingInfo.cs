using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class AccountingInfo
    {
        [Column(TypeName = "datetime")]
        public DateTime Tarih { get; set; }
        [StringLength(50)]
        public string HesapKodu { get; set; }
        [StringLength(100)]
        public string Aciklama { get; set; }
        [Column(TypeName = "money")]
        public decimal FaturaTutari { get; set; }
    }
}
