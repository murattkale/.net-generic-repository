using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Transfer")]
    public partial class StuTransfer
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Trans_Type")]
        [StringLength(20)]
        public string TransType { get; set; }
        [Column("Trans_School")]
        [StringLength(100)]
        public string TransSchool { get; set; }
        [Column("Trans_Faculty")]
        [StringLength(50)]
        public string TransFaculty { get; set; }
        [Column("Trans_Department")]
        [StringLength(50)]
        public string TransDepartment { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StuTransfer")]
        public Student Stu { get; set; }
    }
}
