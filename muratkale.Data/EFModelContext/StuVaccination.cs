using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Vaccination")]
    public partial class StuVaccination
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Vacc_Name")]
        [StringLength(15)]
        public string VaccName { get; set; }
        [Column("Vacc_No")]
        public byte VaccNo { get; set; }
    }
}
