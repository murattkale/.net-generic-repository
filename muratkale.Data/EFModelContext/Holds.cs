using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Holds
    {
        [Key]
        [Column("HoldID")]
        public int HoldId { get; set; }
        [Required]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Hold_Type")]
        [StringLength(50)]
        public string HoldType { get; set; }
        [Required]
        [Column("Hold_Issuer")]
        [StringLength(10)]
        public string HoldIssuer { get; set; }
        [Column("Issuers_Note")]
        [StringLength(255)]
        public string IssuersNote { get; set; }
        [Column("Stop_Registration")]
        public bool? StopRegistration { get; set; }

        [ForeignKey("HoldType")]
        [InverseProperty("Holds")]
        public HoldDesc HoldTypeNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("Holds")]
        public Student Stu { get; set; }
    }
}
