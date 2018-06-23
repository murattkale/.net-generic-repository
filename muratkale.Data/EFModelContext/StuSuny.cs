using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Suny")]
    public partial class StuSuny
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Trans_Type", TypeName = "nchar(9)")]
        public string TransType { get; set; }
        [Required]
        [Column("Trans_School")]
        [StringLength(50)]
        public string TransSchool { get; set; }
        [Required]
        [Column("Trans_Faculty")]
        [StringLength(50)]
        public string TransFaculty { get; set; }
        [Required]
        [Column("Trans_Department")]
        [StringLength(50)]
        public string TransDepartment { get; set; }
        public int Year { get; set; }
        [StringLength(25)]
        public string Semester { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
    }
}
