using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Osym_Prog_Codes")]
    public partial class OsymProgCodes
    {
        [Key]
        [Column("Osym_Prog_ID")]
        public int OsymProgId { get; set; }
        [Required]
        [Column("Program_Code")]
        [StringLength(11)]
        public string ProgramCode { get; set; }
        public int? Year { get; set; }
        [Column("Prog_Name")]
        [StringLength(150)]
        public string ProgName { get; set; }
        [Column("FactID")]
        [StringLength(10)]
        public string FactId { get; set; }
        [StringLength(10)]
        public string DeptId { get; set; }
        [Column("Exam_Type")]
        [StringLength(50)]
        public string ExamType { get; set; }
        [Column("Prog_Name_OSYM")]
        [StringLength(150)]
        public string ProgNameOsym { get; set; }
    }
}
