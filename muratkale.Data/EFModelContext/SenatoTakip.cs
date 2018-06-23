using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Senato_Takip")]
    public partial class SenatoTakip
    {
        [Key]
        [Column("RecordID")]
        public int RecordId { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        public int? SenatoDosya { get; set; }
        public int? SenatoNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Tarih { get; set; }
        [StringLength(1)]
        public string IslemType { get; set; }
        [StringLength(250)]
        public string Ayrinti { get; set; }
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }
    }
}
