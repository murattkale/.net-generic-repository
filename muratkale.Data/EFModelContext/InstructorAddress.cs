using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Instructor_Address")]
    public partial class InstructorAddress
    {
        [Key]
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [Column("Inst_Home_Address1")]
        [StringLength(75)]
        public string InstHomeAddress1 { get; set; }
        [Column("Inst_Home_Address2")]
        [StringLength(75)]
        public string InstHomeAddress2 { get; set; }
        [Column("Inst_Post_Code")]
        [StringLength(5)]
        public string InstPostCode { get; set; }
        [Column("Inst_City")]
        [StringLength(25)]
        public string InstCity { get; set; }
        [Column("Inst_Phone_No")]
        [StringLength(20)]
        public string InstPhoneNo { get; set; }
        [Column("Inst_Phone_No2")]
        [StringLength(20)]
        public string InstPhoneNo2 { get; set; }
        [Column("Inst_Univ_E_Mail")]
        [StringLength(50)]
        public string InstUnivEMail { get; set; }
        [Column("Inst_Other_E_Mail")]
        [StringLength(50)]
        public string InstOtherEMail { get; set; }
    }
}
