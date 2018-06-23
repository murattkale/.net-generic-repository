using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("New_Students")]
    public partial class NewStudents
    {
        [Key]
        [Column("OSYM_No")]
        [StringLength(12)]
        public string OsymNo { get; set; }
        [Column("Stu_FName")]
        [StringLength(20)]
        public string StuFname { get; set; }
        [Column("Stu_MName")]
        [StringLength(20)]
        public string StuMname { get; set; }
        [Column("Stu_LName")]
        [StringLength(20)]
        public string StuLname { get; set; }
        [Column("Dept_Number")]
        [StringLength(25)]
        public string DeptNumber { get; set; }
        [Column("Stu_Type", TypeName = "char(1)")]
        public string StuType { get; set; }
        [Column("AssignedID")]
        [StringLength(11)]
        public string AssignedId { get; set; }
        [Column("PreAssignedID")]
        [StringLength(11)]
        public string PreAssignedId { get; set; }
    }
}
