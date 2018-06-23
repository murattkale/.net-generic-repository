using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Last_Programs")]
    public partial class LastPrograms
    {
        [Key]
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Required]
        [Column("Last_Program")]
        [StringLength(25)]
        public string LastProgram { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("LastPrograms")]
        public Department Dept { get; set; }
        [ForeignKey("LastProgram")]
        [InverseProperty("LastPrograms")]
        public ProgramDepts LastProgramNavigation { get; set; }
    }
}
