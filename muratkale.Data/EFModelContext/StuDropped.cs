using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Dropped")]
    public partial class StuDropped
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Drop_Stu_FName")]
        [StringLength(16)]
        public string DropStuFname { get; set; }
        [Column("Drop_Stu_MName")]
        [StringLength(16)]
        public string DropStuMname { get; set; }
        [Column("Drop_Stu_LName")]
        [StringLength(16)]
        public string DropStuLname { get; set; }
        [Column("Registration_Date", TypeName = "datetime")]
        public DateTime? RegistrationDate { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("Drop_Date", TypeName = "datetime")]
        public DateTime? DropDate { get; set; }
        [Column("Drop_Type")]
        [StringLength(2)]
        public string DropType { get; set; }
        [Column("Drop_Desc")]
        [StringLength(50)]
        public string DropDesc { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("StuDropped")]
        public Department Dept { get; set; }
        [ForeignKey("DropType")]
        [InverseProperty("StuDropped")]
        public DropType DropTypeNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("StuDropped")]
        public Student Stu { get; set; }
    }
}
