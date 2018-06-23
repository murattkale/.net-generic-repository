using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Student_Home_Address")]
    public partial class StudentHomeAddress
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Stu_Home_Address1")]
        [StringLength(250)]
        public string StuHomeAddress1 { get; set; }
        [Column("Stu_Home_Address2")]
        [StringLength(250)]
        public string StuHomeAddress2 { get; set; }
        [Column("Stu_Home_Post_Code")]
        [StringLength(5)]
        public string StuHomePostCode { get; set; }
        [Column("Stu_Home_Phone")]
        [StringLength(11)]
        public string StuHomePhone { get; set; }
        [Required]
        [Column("Stu_Home_City")]
        [StringLength(100)]
        public string StuHomeCity { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StudentHomeAddress")]
        public Student Stu { get; set; }
    }
}
