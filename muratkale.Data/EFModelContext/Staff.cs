using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Staff
    {
        public Staff()
        {
            Department = new HashSet<Department>();
            DepartmentRegistrar = new HashSet<DepartmentRegistrar>();
            DeptPowerUsers = new HashSet<DeptPowerUsers>();
            Faculty = new HashSet<Faculty>();
            ReservedRooms = new HashSet<ReservedRooms>();
        }

        [Column("StaffID")]
        [StringLength(10)]
        public string StaffId { get; set; }
        [Column("Staff_FName")]
        [StringLength(16)]
        public string StaffFname { get; set; }
        [Column("Staff_MName")]
        [StringLength(16)]
        public string StaffMname { get; set; }
        [Column("Staff_LName")]
        [StringLength(32)]
        public string StaffLname { get; set; }
        [Column("Adm_Unit")]
        [StringLength(50)]
        public string AdmUnit { get; set; }
        [Column("Staff_Title")]
        [StringLength(50)]
        public string StaffTitle { get; set; }

        [InverseProperty("SecretaryNavigation")]
        public ICollection<Department> Department { get; set; }
        [InverseProperty("Registrar")]
        public ICollection<DepartmentRegistrar> DepartmentRegistrar { get; set; }
        [InverseProperty("User")]
        public ICollection<DeptPowerUsers> DeptPowerUsers { get; set; }
        [InverseProperty("SecretaryNavigation")]
        public ICollection<Faculty> Faculty { get; set; }
        [InverseProperty("User")]
        public ICollection<ReservedRooms> ReservedRooms { get; set; }
    }
}
