using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Department_Registrar")]
    public partial class DepartmentRegistrar
    {
        [Column("RegistrarID")]
        [StringLength(10)]
        public string RegistrarId { get; set; }
        [Column("DepartmentID")]
        [StringLength(5)]
        public string DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("DepartmentRegistrar")]
        public Department Department { get; set; }
        [ForeignKey("RegistrarId")]
        [InverseProperty("DepartmentRegistrar")]
        public Staff Registrar { get; set; }
    }
}
