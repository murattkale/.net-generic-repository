using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Instructor
    {
        public Instructor()
        {
            ScheduleInstPref = new HashSet<ScheduleInstPref>();
        }

        [Key]
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [Required]
        [Column("Inst_FName")]
        [StringLength(50)]
        public string InstFname { get; set; }
        [Column("Inst_MName")]
        [StringLength(50)]
        public string InstMname { get; set; }
        [Required]
        [Column("Inst_LName")]
        [StringLength(50)]
        public string InstLname { get; set; }
        [Required]
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("Inst_Title")]
        [StringLength(50)]
        public string InstTitle { get; set; }
        [Column("Full_Time")]
        public bool FullTime { get; set; }
        public bool? Active { get; set; }
        [Column("TCkimlik")]
        [StringLength(11)]
        public string Tckimlik { get; set; }
        [StringLength(10)]
        public string Sicil { get; set; }

        [InverseProperty("Inst")]
        public PartTimeInstructorInstitution PartTimeInstructorInstitution { get; set; }
        [InverseProperty("Inst")]
        public TopAdministration TopAdministration { get; set; }
        [InverseProperty("Inst")]
        public ICollection<ScheduleInstPref> ScheduleInstPref { get; set; }
    }
}
