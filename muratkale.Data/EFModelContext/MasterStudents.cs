using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class MasterStudents
    {
        [Key]
        [StringLength(11)]
        public string Stuid { get; set; }
        [StringLength(50)]
        public string OldUniversityName { get; set; }
        [StringLength(50)]
        public string OldUniversityType { get; set; }
        [StringLength(50)]
        public string OldUniversityDept { get; set; }
        [StringLength(20)]
        public string OldUniversityCity { get; set; }
        public int? GraduationYear { get; set; }
        [StringLength(50)]
        public string ForeignLanguage { get; set; }
        public double? ToeflScore { get; set; }
        [StringLength(11)]
        public string AlesNumber { get; set; }
        public double? AlesScore { get; set; }
        public int? AlesRank { get; set; }
        [StringLength(15)]
        public string AlesType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GraduationYear2 { get; set; }
    }
}
