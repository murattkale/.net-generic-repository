using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Student
    {
        public Student()
        {
            AllPrograms = new HashSet<AllPrograms>();
            CumAllSemester = new HashSet<CumAllSemester>();
            CumSemester = new HashSet<CumSemester>();
            DeptConsent = new HashSet<DeptConsent>();
            FinalProgram = new HashSet<FinalProgram>();
            Holds = new HashSet<Holds>();
            IndTrainingRecent = new HashSet<IndTrainingRecent>();
            InstructorConsents = new HashSet<InstructorConsents>();
            PreventDelete = new HashSet<PreventDelete>();
            ProgramsLog = new HashSet<ProgramsLog>();
            RegIterations = new HashSet<RegIterations>();
            SemesterGrades = new HashSet<SemesterGrades>();
            StuClub = new HashSet<StuClub>();
            StuLicence = new HashSet<StuLicence>();
            StuOnLeave = new HashSet<StuOnLeave>();
            StuPenalty = new HashSet<StuPenalty>();
            StuRequest = new HashSet<StuRequest>();
            StuScholarship = new HashSet<StuScholarship>();
            StuTransfer = new HashSet<StuTransfer>();
            SuggestedProgram = new HashSet<SuggestedProgram>();
        }

        [Key]
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Stu_FName")]
        [StringLength(20)]
        public string StuFname { get; set; }
        [Column("Stu_MName")]
        [StringLength(20)]
        public string StuMname { get; set; }
        [Column("Stu_LName")]
        [StringLength(40)]
        public string StuLname { get; set; }
        [Required]
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Required]
        [Column("Stu_Standing")]
        [StringLength(16)]
        public string StuStanding { get; set; }
        [Required]
        [Column("Stu_Status")]
        [StringLength(16)]
        public string StuStatus { get; set; }
        [Required]
        [Column("ProgramID")]
        [StringLength(10)]
        public string ProgramId { get; set; }
        [Column("Prep_Class")]
        public bool PrepClass { get; set; }
        [Column("Registration_Date", TypeName = "datetime")]
        public DateTime RegistrationDate { get; set; }
        [Column("First_Year")]
        public bool? FirstYear { get; set; }
        [Column("Program_Entry_Year")]
        public int? ProgramEntryYear { get; set; }
        [Column("Program_Entry_Semester")]
        [StringLength(50)]
        public string ProgramEntrySemester { get; set; }

        [InverseProperty("Stu")]
        public Advisor Advisor { get; set; }
        [InverseProperty("Stu")]
        public AvoidMaslak AvoidMaslak { get; set; }
        [InverseProperty("Stu")]
        public DmMApprovalStatus DmMApprovalStatus { get; set; }
        [InverseProperty("Stu")]
        public DoubleMajor DoubleMajor { get; set; }
        [InverseProperty("Stu")]
        public FinalGpa FinalGpa { get; set; }
        [InverseProperty("Stu")]
        public IntibakAgreed IntibakAgreed { get; set; }
        [InverseProperty("Stu")]
        public Minor Minor { get; set; }
        [InverseProperty("Stu")]
        public Passcard Passcard { get; set; }
        [InverseProperty("Stu")]
        public PlacementScores PlacementScores { get; set; }
        [InverseProperty("Stu")]
        public ProficiencyScores ProficiencyScores { get; set; }
        [InverseProperty("Stu")]
        public RegStatus RegStatus { get; set; }
        [InverseProperty("Stu")]
        public RegistrationFlags RegistrationFlags { get; set; }
        [InverseProperty("StuNavigation")]
        public StuBackground StuBackground { get; set; }
        [InverseProperty("Stu")]
        public StuDropped StuDropped { get; set; }
        [InverseProperty("Stu")]
        public StuOverPeriod StuOverPeriod { get; set; }
        [InverseProperty("Stu")]
        public StuPardoned StuPardoned { get; set; }
        [InverseProperty("Stu")]
        public StudentAddress StudentAddress { get; set; }
        [InverseProperty("Stu")]
        public StudentHomeAddress StudentHomeAddress { get; set; }
        [InverseProperty("Stu")]
        public StudentId StudentId { get; set; }
        [InverseProperty("Stu")]
        public StudentMilitary StudentMilitary { get; set; }
        [InverseProperty("Stu")]
        public SummerTuition SummerTuition { get; set; }
        [InverseProperty("Stu")]
        public Trccr Trccr { get; set; }
        [InverseProperty("Stu")]
        public ICollection<AllPrograms> AllPrograms { get; set; }
        [InverseProperty("Stu")]
        public ICollection<CumAllSemester> CumAllSemester { get; set; }
        [InverseProperty("Stu")]
        public ICollection<CumSemester> CumSemester { get; set; }
        [InverseProperty("Stu")]
        public ICollection<DeptConsent> DeptConsent { get; set; }
        [InverseProperty("Stu")]
        public ICollection<FinalProgram> FinalProgram { get; set; }
        [InverseProperty("Stu")]
        public ICollection<Holds> Holds { get; set; }
        [InverseProperty("Stu")]
        public ICollection<IndTrainingRecent> IndTrainingRecent { get; set; }
        [InverseProperty("Stu")]
        public ICollection<InstructorConsents> InstructorConsents { get; set; }
        [InverseProperty("Stu")]
        public ICollection<PreventDelete> PreventDelete { get; set; }
        [InverseProperty("Stu")]
        public ICollection<ProgramsLog> ProgramsLog { get; set; }
        [InverseProperty("Stu")]
        public ICollection<RegIterations> RegIterations { get; set; }
        [InverseProperty("Stu")]
        public ICollection<SemesterGrades> SemesterGrades { get; set; }
        [InverseProperty("Stu")]
        public ICollection<StuClub> StuClub { get; set; }
        [InverseProperty("Stu")]
        public ICollection<StuLicence> StuLicence { get; set; }
        [InverseProperty("Stu")]
        public ICollection<StuOnLeave> StuOnLeave { get; set; }
        [InverseProperty("Stu")]
        public ICollection<StuPenalty> StuPenalty { get; set; }
        [InverseProperty("Stu")]
        public ICollection<StuRequest> StuRequest { get; set; }
        [InverseProperty("Stu")]
        public ICollection<StuScholarship> StuScholarship { get; set; }
        [InverseProperty("Stu")]
        public ICollection<StuTransfer> StuTransfer { get; set; }
        [InverseProperty("Stu")]
        public ICollection<SuggestedProgram> SuggestedProgram { get; set; }
    }
}
