using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Prospect_Personal_Info")]
    public partial class ProspectPersonalInfo
    {
        [Key]
        [Column("Stu_ID_No")]
        [StringLength(12)]
        public string StuIdNo { get; set; }
        [Column("Stu_Gender")]
        [StringLength(50)]
        public string StuGender { get; set; }
        [Column("Stu_Nationality")]
        [StringLength(50)]
        public string StuNationality { get; set; }
        [Column("Stu_Fathers_Name")]
        [StringLength(30)]
        public string StuFathersName { get; set; }
        [Column("Stu_Mathers_Name")]
        [StringLength(30)]
        public string StuMathersName { get; set; }
        [Column("Stu_Date_Of_Birth", TypeName = "datetime")]
        public DateTime? StuDateOfBirth { get; set; }
        [Column("Stu_Place_Of_Birth")]
        [StringLength(50)]
        public string StuPlaceOfBirth { get; set; }
        [Column("Stu_Address_1")]
        [StringLength(250)]
        public string StuAddress1 { get; set; }
        [Column("Stu_Address_2")]
        [StringLength(50)]
        public string StuAddress2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [Column("Stu_Phone1")]
        [StringLength(20)]
        public string StuPhone1 { get; set; }
        [Column("Stu_Cellular_Phone")]
        [StringLength(20)]
        public string StuCellularPhone { get; set; }
        [Column("Stu_Other_E_Mail")]
        [StringLength(100)]
        public string StuOtherEMail { get; set; }
    }
}
