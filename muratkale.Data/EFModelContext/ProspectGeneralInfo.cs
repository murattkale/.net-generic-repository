using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Prospect_General_Info")]
    public partial class ProspectGeneralInfo
    {
        [Key]
        [Column("Stu_ID_No")]
        [StringLength(12)]
        public string StuIdNo { get; set; }
        [Column("Stu_FName")]
        [StringLength(20)]
        public string StuFname { get; set; }
        [Column("Stu_MName")]
        [StringLength(20)]
        public string StuMname { get; set; }
        [Column("Stu_LName")]
        [StringLength(40)]
        public string StuLname { get; set; }
        [Column("factID")]
        public int? FactId { get; set; }
        [StringLength(11)]
        public string ProgramCode { get; set; }
        [StringLength(50)]
        public string BasvuruTuru { get; set; }
    }
}
