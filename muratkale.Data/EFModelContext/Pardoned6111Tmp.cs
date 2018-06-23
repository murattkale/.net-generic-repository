using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("pardoned6111_tmp")]
    public partial class Pardoned6111Tmp
    {
        [StringLength(11)]
        public string Stuid { get; set; }
        [StringLength(5)]
        public string Deptid { get; set; }
        public int Year { get; set; }
        [Required]
        [StringLength(25)]
        public string Semester { get; set; }
        [Column("Registration_Flag")]
        public bool? RegistrationFlag { get; set; }
        [Required]
        [StringLength(50)]
        public string Regdate { get; set; }
    }
}
