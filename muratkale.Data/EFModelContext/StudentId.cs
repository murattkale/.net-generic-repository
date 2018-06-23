using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Student_ID")]
    public partial class StudentId
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Stu_ID_No")]
        [StringLength(12)]
        public string StuIdNo { get; set; }
        [Column("Stu_Gender", TypeName = "nchar(1)")]
        public string StuGender { get; set; }
        [Column("Stu_Nationality")]
        [StringLength(30)]
        public string StuNationality { get; set; }
        [Column("Stu_Fathers_Name")]
        [StringLength(30)]
        public string StuFathersName { get; set; }
        [Column("Stu_Mothers_Name")]
        [StringLength(30)]
        public string StuMothersName { get; set; }
        [Column("Stu_Date_Of_Birth", TypeName = "datetime")]
        public DateTime? StuDateOfBirth { get; set; }
        [Column("Stu_Place_Of_Birth")]
        [StringLength(50)]
        public string StuPlaceOfBirth { get; set; }
        [Column("Stu_Marital_Status")]
        [StringLength(10)]
        public string StuMaritalStatus { get; set; }
        [Column("Stu_Religion")]
        [StringLength(10)]
        public string StuReligion { get; set; }
        [Column("Stu_Blood_Type")]
        [StringLength(50)]
        public string StuBloodType { get; set; }
        [Column("Stu_Regist_Province")]
        [StringLength(30)]
        public string StuRegistProvince { get; set; }
        [Column("Stu_Regist_Town")]
        [StringLength(30)]
        public string StuRegistTown { get; set; }
        [Column("Stu_Regist_Village")]
        [StringLength(50)]
        public string StuRegistVillage { get; set; }
        [Column("Stu_Regist_No")]
        [StringLength(10)]
        public string StuRegistNo { get; set; }
        [Column("Stu_Order_No")]
        [StringLength(10)]
        public string StuOrderNo { get; set; }
        [Column("Stu_Family_No")]
        [StringLength(10)]
        public string StuFamilyNo { get; set; }
        [Column("Fathers_Job")]
        [StringLength(50)]
        public string FathersJob { get; set; }
        [Column("Mothers_Job")]
        [StringLength(50)]
        public string MothersJob { get; set; }
        [Column("Spouse_Name")]
        [StringLength(16)]
        public string SpouseName { get; set; }
        [Column("Spouse_Job")]
        [StringLength(25)]
        public string SpouseJob { get; set; }
        [StringLength(50)]
        public string Photo { get; set; }
        [Column("eesicilyar")]
        [StringLength(50)]
        public string Eesicilyar { get; set; }
        [Column("eesicilsag")]
        [StringLength(50)]
        public string Eesicilsag { get; set; }
        [Column("eesicilkendi")]
        [StringLength(50)]
        public string Eesicilkendi { get; set; }
        [Column("passport_no")]
        [StringLength(15)]
        public string PassportNo { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StudentId")]
        public Student Stu { get; set; }
    }
}
