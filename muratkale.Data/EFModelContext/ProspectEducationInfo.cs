using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Prospect_Education_Info")]
    public partial class ProspectEducationInfo
    {
        [Key]
        [Column("Stu_ID_No")]
        [StringLength(12)]
        public string StuIdNo { get; set; }
        [Column("High_School")]
        [StringLength(250)]
        public string HighSchool { get; set; }
        [Column("High_School_Type")]
        [StringLength(70)]
        public string HighSchoolType { get; set; }
        [Column("High_School_Branch")]
        [StringLength(70)]
        public string HighSchoolBranch { get; set; }
        [Column("High_School_Graduation_Date", TypeName = "datetime")]
        public DateTime? HighSchoolGraduationDate { get; set; }
        [Column("High_School_City")]
        [StringLength(25)]
        public string HighSchoolCity { get; set; }
        [StringLength(100)]
        public string Institution { get; set; }
        [Column("derece")]
        [StringLength(20)]
        public string Derece { get; set; }
        [StringLength(50)]
        public string Faculty { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GraduationYear { get; set; }
        public double? AlesScore { get; set; }
        [StringLength(15)]
        public string AlesType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AlesDate { get; set; }
        [StringLength(50)]
        public string ForeignLanguage { get; set; }
        [Column("ForeignLanguage_Exam")]
        [StringLength(50)]
        public string ForeignLanguageExam { get; set; }
        public double? ForeignLanguageScore { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ForeignLanguageExamDate { get; set; }
    }
}
