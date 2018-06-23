using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Background")]
    public partial class StuBackground
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("High_School_Type")]
        [StringLength(70)]
        public string HighSchoolType { get; set; }
        [Column("High_School_Branch")]
        [StringLength(70)]
        public string HighSchoolBranch { get; set; }
        [Column("High_School")]
        [StringLength(250)]
        public string HighSchool { get; set; }
        [Column("Graduation_Date")]
        public int? GraduationDate { get; set; }
        [Column("High_School_City")]
        [StringLength(25)]
        public string HighSchoolCity { get; set; }
        [Column("Foreign_Lang")]
        [StringLength(50)]
        public string ForeignLang { get; set; }
        [Column("Toefl_Score")]
        public double? ToeflScore { get; set; }
        [Column("OSS_Number", TypeName = "nchar(11)")]
        public string OssNumber { get; set; }
        [Column("OSS_Choice_Rank")]
        public int? OssChoiceRank { get; set; }
        [Column("OSS_Score_Type")]
        [StringLength(20)]
        public string OssScoreType { get; set; }
        [Column("OSS_Score")]
        [StringLength(50)]
        public string OssScore { get; set; }
        [Column("Success_Rank")]
        [StringLength(10)]
        public string SuccessRank { get; set; }
        [Column("AOBP")]
        public double? Aobp { get; set; }
        [Column("Oss_Prog_Code")]
        [StringLength(20)]
        public string OssProgCode { get; set; }
        [Column("YOK_birim")]
        [StringLength(20)]
        public string YokBirim { get; set; }
        [Column("Coming_Type")]
        public int? ComingType { get; set; }

        [ForeignKey("ComingType")]
        [InverseProperty("StuBackground")]
        public ComingTypes ComingTypeNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("InverseStu")]
        public StuBackground Stu { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("StuBackground")]
        public Student StuNavigation { get; set; }
        [InverseProperty("Stu")]
        public StuBackground InverseStu { get; set; }
    }
}
