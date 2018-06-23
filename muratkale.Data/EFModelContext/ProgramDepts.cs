using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Program_Depts")]
    public partial class ProgramDepts
    {
        public ProgramDepts()
        {
            ClassCredits = new HashSet<ClassCredits>();
            CourseGroups = new HashSet<CourseGroups>();
            DoubleMajor = new HashSet<DoubleMajor>();
            LastPrograms = new HashSet<LastPrograms>();
            Minor = new HashSet<Minor>();
            NoForceF = new HashSet<NoForceF>();
            Program = new HashSet<Program>();
            SemesterLoads = new HashSet<SemesterLoads>();
            StandingParams = new HashSet<StandingParams>();
            Substitution = new HashSet<Substitution>();
        }

        [Key]
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("ProgramAdi_Eng")]
        [StringLength(150)]
        public string ProgramAdiEng { get; set; }
        [Column("ProgramAdi_Tur")]
        [StringLength(150)]
        public string ProgramAdiTur { get; set; }
        public byte? Visibility { get; set; }
        [Column("Program_Level")]
        [StringLength(50)]
        public string ProgramLevel { get; set; }
        [StringLength(50)]
        public string Tur { get; set; }
        [StringLength(25)]
        public string Language { get; set; }
        [Column("unvan")]
        [StringLength(6)]
        public string Unvan { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("ProgramDepts")]
        public Department Dept { get; set; }
        [InverseProperty("Program")]
        public BachelorPrint BachelorPrint { get; set; }
        [InverseProperty("ProgramNavigation")]
        public DiplomaSablon DiplomaSablon { get; set; }
        [InverseProperty("Program")]
        public DiplomaTaslak2017 DiplomaTaslak2017 { get; set; }
        [InverseProperty("Program")]
        public Senator Senator { get; set; }
        [InverseProperty("Program")]
        public ICollection<ClassCredits> ClassCredits { get; set; }
        [InverseProperty("Program")]
        public ICollection<CourseGroups> CourseGroups { get; set; }
        [InverseProperty("Program")]
        public ICollection<DoubleMajor> DoubleMajor { get; set; }
        [InverseProperty("LastProgramNavigation")]
        public ICollection<LastPrograms> LastPrograms { get; set; }
        [InverseProperty("Program")]
        public ICollection<Minor> Minor { get; set; }
        [InverseProperty("Program")]
        public ICollection<NoForceF> NoForceF { get; set; }
        [InverseProperty("ProgramNavigation")]
        public ICollection<Program> Program { get; set; }
        [InverseProperty("Program")]
        public ICollection<SemesterLoads> SemesterLoads { get; set; }
        [InverseProperty("Program")]
        public ICollection<StandingParams> StandingParams { get; set; }
        [InverseProperty("Program")]
        public ICollection<Substitution> Substitution { get; set; }
    }
}
