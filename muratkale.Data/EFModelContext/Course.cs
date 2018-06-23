using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Course
    {
        public Course()
        {
            AllPrograms = new HashSet<AllPrograms>();
            CourseGroups = new HashSet<CourseGroups>();
            CourseRequirements = new HashSet<CourseRequirements>();
            ExemptionCoordinator = new HashSet<ExemptionCoordinator>();
            FinalExamRoom = new HashSet<FinalExamRoom>();
            FinalExamSchedule = new HashSet<FinalExamSchedule>();
            FinalProgram = new HashSet<FinalProgram>();
            IndTrainingCoordinator = new HashSet<IndTrainingCoordinator>();
            ScheduleCampusSummer = new HashSet<ScheduleCampusSummer>();
            ScheduleCampusTemp = new HashSet<ScheduleCampusTemp>();
            ScheduleGroups = new HashSet<ScheduleGroups>();
            ScheduleOwner = new HashSet<ScheduleOwner>();
            SemesterGrades = new HashSet<SemesterGrades>();
            StuMultipleTakenFor = new HashSet<StuMultipleTakenFor>();
            SuggestedProgram = new HashSet<SuggestedProgram>();
        }

        [Key]
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Required]
        [Column("Course_Title")]
        [StringLength(200)]
        public string CourseTitle { get; set; }
        [Column("Course_Credit")]
        public byte CourseCredit { get; set; }
        [Column("Lect_Hours")]
        public byte LectHours { get; set; }
        [Column("Lab_Hours")]
        public byte LabHours { get; set; }
        [Column("PS_Hours")]
        public byte PsHours { get; set; }
        [Column("Course_Dept")]
        [StringLength(5)]
        public string CourseDept { get; set; }
        [Column("Course_Type")]
        [StringLength(15)]
        public string CourseType { get; set; }
        public bool? Active { get; set; }
        [Column("ECTS_Credit", TypeName = "decimal(18, 1)")]
        public decimal? EctsCredit { get; set; }

        [InverseProperty("CourseCodeNavigation")]
        public CourseDesc CourseDesc { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<AllPrograms> AllPrograms { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<CourseGroups> CourseGroups { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<CourseRequirements> CourseRequirements { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<ExemptionCoordinator> ExemptionCoordinator { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<FinalExamRoom> FinalExamRoom { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<FinalExamSchedule> FinalExamSchedule { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<FinalProgram> FinalProgram { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<IndTrainingCoordinator> IndTrainingCoordinator { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<ScheduleCampusSummer> ScheduleCampusSummer { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<ScheduleCampusTemp> ScheduleCampusTemp { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<ScheduleGroups> ScheduleGroups { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<ScheduleOwner> ScheduleOwner { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<SemesterGrades> SemesterGrades { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<StuMultipleTakenFor> StuMultipleTakenFor { get; set; }
        [InverseProperty("CourseCodeNavigation")]
        public ICollection<SuggestedProgram> SuggestedProgram { get; set; }
    }
}
