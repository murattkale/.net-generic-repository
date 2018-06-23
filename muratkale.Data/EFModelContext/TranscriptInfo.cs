using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class TranscriptInfo
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Birthplacedate { get; set; }
        [StringLength(100)]
        public string Faculty { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [StringLength(50)]
        public string Major { get; set; }
        [StringLength(50)]
        public string DoubleMajor { get; set; }
        [StringLength(50)]
        public string Minor { get; set; }
        [StringLength(50)]
        public string HighSchool { get; set; }
        [StringLength(50)]
        public string DateRegistered { get; set; }
        [StringLength(50)]
        public string DateGraduated { get; set; }
        [StringLength(50)]
        public string GraduationStanding { get; set; }
        [StringLength(50)]
        public string DegreeAwarded { get; set; }
        [Column("EFLEnterance")]
        [StringLength(50)]
        public string Eflenterance { get; set; }
        [Column("EFLExitance")]
        [StringLength(50)]
        public string Eflexitance { get; set; }
        [Column("EFLGrade")]
        [StringLength(50)]
        public string Eflgrade { get; set; }
    }
}
