using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Department
    {
        public Department()
        {
            CheckCategories = new HashSet<CheckCategories>();
            DepartmentRegistrar = new HashSet<DepartmentRegistrar>();
            DeptPowerUsers = new HashSet<DeptPowerUsers>();
            Electives = new HashSet<Electives>();
            ProgramDepts = new HashSet<ProgramDepts>();
            Regulations = new HashSet<Regulations>();
            StuDropped = new HashSet<StuDropped>();
        }

        [Key]
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Required]
        [Column("FactID")]
        [StringLength(10)]
        public string FactId { get; set; }
        [Required]
        [Column("Dept_Name")]
        [StringLength(60)]
        public string DeptName { get; set; }
        [Required]
        [Column("Head_of_Dept")]
        [StringLength(10)]
        public string HeadOfDept { get; set; }
        [Column("Dept_Tur_Name")]
        [StringLength(60)]
        public string DeptTurName { get; set; }
        [StringLength(10)]
        public string Secretary { get; set; }

        [ForeignKey("FactId")]
        [InverseProperty("Department")]
        public Faculty Fact { get; set; }
        [ForeignKey("Secretary")]
        [InverseProperty("Department")]
        public Staff SecretaryNavigation { get; set; }
        [InverseProperty("Dept")]
        public DeptPeriods DeptPeriods { get; set; }
        [InverseProperty("Dept")]
        public LastPrograms LastPrograms { get; set; }
        [InverseProperty("Dept")]
        public ICollection<CheckCategories> CheckCategories { get; set; }
        [InverseProperty("Department")]
        public ICollection<DepartmentRegistrar> DepartmentRegistrar { get; set; }
        [InverseProperty("Dept")]
        public ICollection<DeptPowerUsers> DeptPowerUsers { get; set; }
        [InverseProperty("Dept")]
        public ICollection<Electives> Electives { get; set; }
        [InverseProperty("Dept")]
        public ICollection<ProgramDepts> ProgramDepts { get; set; }
        [InverseProperty("Dept")]
        public ICollection<Regulations> Regulations { get; set; }
        [InverseProperty("Dept")]
        public ICollection<StuDropped> StuDropped { get; set; }
    }
}
