using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Health")]
    public partial class StuHealth
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public byte? Weight { get; set; }
        public double? Height { get; set; }
        [Column("Family_Doc_Name")]
        [StringLength(32)]
        public string FamilyDocName { get; set; }
        [Column("Family_Doc_Address1")]
        [StringLength(75)]
        public string FamilyDocAddress1 { get; set; }
        [Column("Family_Doc_Address2")]
        [StringLength(75)]
        public string FamilyDocAddress2 { get; set; }
        [Column("Family_Doc_Phone1", TypeName = "char(11)")]
        public string FamilyDocPhone1 { get; set; }
        [Column("Family_Doc_Phone2", TypeName = "char(11)")]
        public string FamilyDocPhone2 { get; set; }
        [Column("Last_Optical_Exam_Date", TypeName = "datetime")]
        public DateTime? LastOpticalExamDate { get; set; }
        [Column("Last_Dentist_Exam_Date", TypeName = "datetime")]
        public DateTime? LastDentistExamDate { get; set; }
        [Column("Last_KBB_Exam_Date", TypeName = "datetime")]
        public DateTime? LastKbbExamDate { get; set; }
    }
}
