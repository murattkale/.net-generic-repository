using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Student_Address")]
    public partial class StudentAddress
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Stu_Address_1")]
        [StringLength(250)]
        public string StuAddress1 { get; set; }
        [Column("Stu_Address_2")]
        [StringLength(100)]
        public string StuAddress2 { get; set; }
        [Required]
        [Column("Stu_Post_Code")]
        [StringLength(5)]
        public string StuPostCode { get; set; }
        [Column("Stu_Phone1")]
        [StringLength(20)]
        public string StuPhone1 { get; set; }
        [Column("Stu_Phone2")]
        [StringLength(20)]
        public string StuPhone2 { get; set; }
        [Column("Stu_Cellular_Phone")]
        [StringLength(20)]
        public string StuCellularPhone { get; set; }
        [Column("Stu_Emerg_Name")]
        [StringLength(32)]
        public string StuEmergName { get; set; }
        [Column("Stu_Emerg_Address1")]
        [StringLength(75)]
        public string StuEmergAddress1 { get; set; }
        [Column("Stu_Emerg_Address2")]
        [StringLength(75)]
        public string StuEmergAddress2 { get; set; }
        [Column("Stu_Emerg_Phone1")]
        [StringLength(20)]
        public string StuEmergPhone1 { get; set; }
        [Column("Stu_Emerg_Phone2")]
        [StringLength(20)]
        public string StuEmergPhone2 { get; set; }
        [Column("Stu_Univ_E_Mail")]
        [StringLength(100)]
        public string StuUnivEMail { get; set; }
        [Column("Stu_Other_E_Mail")]
        [StringLength(100)]
        public string StuOtherEMail { get; set; }
        [Column("IETT_No", TypeName = "nchar(10)")]
        public string IettNo { get; set; }
        [StringLength(50)]
        public string City { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StudentAddress")]
        public Student Stu { get; set; }
    }
}
