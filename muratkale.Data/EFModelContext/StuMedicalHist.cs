using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Medical_Hist")]
    public partial class StuMedicalHist
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Type_of_Record")]
        [StringLength(20)]
        public string TypeOfRecord { get; set; }
        [Column("Record_Text")]
        [StringLength(75)]
        public string RecordText { get; set; }
        public byte Age { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}
