using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Registration_Flags")]
    public partial class RegistrationFlags
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public bool Approved { get; set; }
        [Column("End_With_Advisor")]
        public bool EndWithAdvisor { get; set; }
        [Column("Consult_To_Advisor")]
        public bool ConsultToAdvisor { get; set; }
        public bool Withdrawal { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("RegistrationFlags")]
        public Student Stu { get; set; }
    }
}
