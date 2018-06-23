using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Student_Military")]
    public partial class StudentMilitary
    {
        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Required]
        [Column("Military_Draft_Service")]
        [StringLength(50)]
        public string MilitaryDraftService { get; set; }
        [Required]
        [Column("Stu_Mil_Province")]
        [StringLength(20)]
        public string StuMilProvince { get; set; }
        [Required]
        [Column("Stu_Mil_Town")]
        [StringLength(20)]
        public string StuMilTown { get; set; }
        [Required]
        [Column("Stu_Mil_Village")]
        [StringLength(20)]
        public string StuMilVillage { get; set; }
        [Column("Military_Status")]
        public bool? MilitaryStatus { get; set; }
        [Column("Date_Postponed", TypeName = "smalldatetime")]
        public DateTime? DatePostponed { get; set; }
        [Column("Regional_Draft_Office")]
        [StringLength(20)]
        public string RegionalDraftOffice { get; set; }
        [Column("Regional_Draft_City")]
        [StringLength(20)]
        public string RegionalDraftCity { get; set; }

        [ForeignKey("StuId")]
        [InverseProperty("StudentMilitary")]
        public Student Stu { get; set; }
    }
}
