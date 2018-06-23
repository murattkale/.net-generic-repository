using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace muratkale.Data.EFModelContext
{
    public partial class EFContext : DbContext
    {
        public virtual DbSet<AccountingInfo> AccountingInfo { get; set; }
        public virtual DbSet<Advisor> Advisor { get; set; }
        public virtual DbSet<AllPrograms> AllPrograms { get; set; }
        public virtual DbSet<Announcements> Announcements { get; set; }
        public virtual DbSet<Askerlikyazi> Askerlikyazi { get; set; }
        public virtual DbSet<AuthenticationComputers> AuthenticationComputers { get; set; }
        public virtual DbSet<AvoidMaslak> AvoidMaslak { get; set; }
        public virtual DbSet<BachelorPrint> BachelorPrint { get; set; }
        public virtual DbSet<BursKategori> BursKategori { get; set; }
        public virtual DbSet<CategoryType> CategoryType { get; set; }
        public virtual DbSet<Ccr> Ccr { get; set; }
        public virtual DbSet<CcrDoubleTest> CcrDoubleTest { get; set; }
        public virtual DbSet<CheckCategories> CheckCategories { get; set; }
        public virtual DbSet<ClassCredits> ClassCredits { get; set; }
        public virtual DbSet<Clubs> Clubs { get; set; }
        public virtual DbSet<ColInsertTrace> ColInsertTrace { get; set; }
        public virtual DbSet<ComingTypes> ComingTypes { get; set; }
        public virtual DbSet<CoRequisite> CoRequisite { get; set; }
        public virtual DbSet<CoRequisiteOr> CoRequisiteOr { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseDesc> CourseDesc { get; set; }
        public virtual DbSet<CourseGroups> CourseGroups { get; set; }
        public virtual DbSet<CourseRequirements> CourseRequirements { get; set; }
        public virtual DbSet<CoursesOfferedSummer> CoursesOfferedSummer { get; set; }
        public virtual DbSet<CoursesOfferedTemp> CoursesOfferedTemp { get; set; }
        public virtual DbSet<CourseWebApiTrace> CourseWebApiTrace { get; set; }
        public virtual DbSet<CourseWebApiUsers> CourseWebApiUsers { get; set; }
        public virtual DbSet<CumAllSemester> CumAllSemester { get; set; }
        public virtual DbSet<CumSemester> CumSemester { get; set; }
        public virtual DbSet<CurrentAcadCalendar> CurrentAcadCalendar { get; set; }
        public virtual DbSet<CurrentCourseQuota> CurrentCourseQuota { get; set; }
        public virtual DbSet<CurrentCourseQuotaSummer> CurrentCourseQuotaSummer { get; set; }
        public virtual DbSet<CurrentCourseQuotaTemp> CurrentCourseQuotaTemp { get; set; }
        public virtual DbSet<CurrentCourseSchedule> CurrentCourseSchedule { get; set; }
        public virtual DbSet<CurrentCourseScheduleSummer> CurrentCourseScheduleSummer { get; set; }
        public virtual DbSet<CurrentCourseScheduleTemp> CurrentCourseScheduleTemp { get; set; }
        public virtual DbSet<CvActivity> CvActivity { get; set; }
        public virtual DbSet<CvFavoriteCourses> CvFavoriteCourses { get; set; }
        public virtual DbSet<CvFormShow> CvFormShow { get; set; }
        public virtual DbSet<CvInterest> CvInterest { get; set; }
        public virtual DbSet<CvLang> CvLang { get; set; }
        public virtual DbSet<CvMembership> CvMembership { get; set; }
        public virtual DbSet<CvPersonal> CvPersonal { get; set; }
        public virtual DbSet<CvSkills> CvSkills { get; set; }
        public virtual DbSet<CvStuInterest> CvStuInterest { get; set; }
        public virtual DbSet<CvStuLang> CvStuLang { get; set; }
        public virtual DbSet<CvStuPersonal> CvStuPersonal { get; set; }
        public virtual DbSet<CvStuSkills> CvStuSkills { get; set; }
        public virtual DbSet<CvWorkExperience> CvWorkExperience { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentRegistrar> DepartmentRegistrar { get; set; }
        public virtual DbSet<DeptConsent> DeptConsent { get; set; }
        public virtual DbSet<DeptPeriods> DeptPeriods { get; set; }
        public virtual DbSet<DeptPowerUsers> DeptPowerUsers { get; set; }
        public virtual DbSet<Derslik> Derslik { get; set; }
        public virtual DbSet<DiplomaSablon> DiplomaSablon { get; set; }
        public virtual DbSet<DiplomaTaslak2017> DiplomaTaslak2017 { get; set; }
        public virtual DbSet<DmMApprovalStatus> DmMApprovalStatus { get; set; }
        public virtual DbSet<DoubleMajor> DoubleMajor { get; set; }
        public virtual DbSet<DropType> DropType { get; set; }
        public virtual DbSet<EflCourses> EflCourses { get; set; }
        public virtual DbSet<EflStudent> EflStudent { get; set; }
        public virtual DbSet<EflTracks> EflTracks { get; set; }
        public virtual DbSet<EksikEvrak> EksikEvrak { get; set; }
        public virtual DbSet<Electives> Electives { get; set; }
        public virtual DbSet<EventLog> EventLog { get; set; }
        public virtual DbSet<EventTypes> EventTypes { get; set; }
        public virtual DbSet<ExemptionCoordinator> ExemptionCoordinator { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<FebEvents> FebEvents { get; set; }
        public virtual DbSet<FebLog> FebLog { get; set; }
        public virtual DbSet<FinalExamRoom> FinalExamRoom { get; set; }
        public virtual DbSet<FinalExamSchedule> FinalExamSchedule { get; set; }
        public virtual DbSet<FinalGpa> FinalGpa { get; set; }
        public virtual DbSet<FinalProgram> FinalProgram { get; set; }
        public virtual DbSet<FunctionDefinition> FunctionDefinition { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<GradesIntibak> GradesIntibak { get; set; }
        public virtual DbSet<GradesSymbols> GradesSymbols { get; set; }
        public virtual DbSet<GrsPuanTur> GrsPuanTur { get; set; }
        public virtual DbSet<GsmKontrol> GsmKontrol { get; set; }
        public virtual DbSet<GsmtelCodes> GsmtelCodes { get; set; }
        public virtual DbSet<Hatalar> Hatalar { get; set; }
        public virtual DbSet<HazirlikSinav> HazirlikSinav { get; set; }
        public virtual DbSet<HighSchools> HighSchools { get; set; }
        public virtual DbSet<HoldDesc> HoldDesc { get; set; }
        public virtual DbSet<Holds> Holds { get; set; }
        public virtual DbSet<HssCodes> HssCodes { get; set; }
        public virtual DbSet<IndTrainingCoordinator> IndTrainingCoordinator { get; set; }
        public virtual DbSet<IndTrainingRecent> IndTrainingRecent { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<InstructorAddress> InstructorAddress { get; set; }
        public virtual DbSet<InstructorConsents> InstructorConsents { get; set; }
        public virtual DbSet<InstructorOffice> InstructorOffice { get; set; }
        public virtual DbSet<IntibakAgreed> IntibakAgreed { get; set; }
        public virtual DbSet<KhkOgrenciler> KhkOgrenciler { get; set; }
        public virtual DbSet<LastGpa> LastGpa { get; set; }
        public virtual DbSet<LastPrograms> LastPrograms { get; set; }
        public virtual DbSet<MasterStudents> MasterStudents { get; set; }
        public virtual DbSet<MasterThesis> MasterThesis { get; set; }
        public virtual DbSet<Minor> Minor { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewStudents> NewStudents { get; set; }
        public virtual DbSet<NoForceF> NoForceF { get; set; }
        public virtual DbSet<OldCourseSchedule> OldCourseSchedule { get; set; }
        public virtual DbSet<OsymProgCodes> OsymProgCodes { get; set; }
        public virtual DbSet<OsymYerlesen> OsymYerlesen { get; set; }
        public virtual DbSet<ParallelCoRequisite> ParallelCoRequisite { get; set; }
        public virtual DbSet<ParameterCityProvince> ParameterCityProvince { get; set; }
        public virtual DbSet<ParameterHighSchool> ParameterHighSchool { get; set; }
        public virtual DbSet<ParameterYear> ParameterYear { get; set; }
        public virtual DbSet<ParamPhDstatus> ParamPhDstatus { get; set; }
        public virtual DbSet<Pardoned6111> Pardoned6111 { get; set; }
        public virtual DbSet<Pardoned6111Tmp> Pardoned6111Tmp { get; set; }
        public virtual DbSet<PartTimeInstructorInstitution> PartTimeInstructorInstitution { get; set; }
        public virtual DbSet<Passcard> Passcard { get; set; }
        public virtual DbSet<PasswordChanger> PasswordChanger { get; set; }
        public virtual DbSet<Penalties> Penalties { get; set; }
        public virtual DbSet<PetitionDetails> PetitionDetails { get; set; }
        public virtual DbSet<PetitionHeader> PetitionHeader { get; set; }
        public virtual DbSet<PetitionReviews> PetitionReviews { get; set; }
        public virtual DbSet<Petitions> Petitions { get; set; }
        public virtual DbSet<PlacementScores> PlacementScores { get; set; }
        public virtual DbSet<Prerequisite> Prerequisite { get; set; }
        public virtual DbSet<PrerequisiteOr> PrerequisiteOr { get; set; }
        public virtual DbSet<PreventDelete> PreventDelete { get; set; }
        public virtual DbSet<ProficiencyScores> ProficiencyScores { get; set; }
        public virtual DbSet<Program> Program { get; set; }
        public virtual DbSet<ProgramCodes> ProgramCodes { get; set; }
        public virtual DbSet<ProgramDepts> ProgramDepts { get; set; }
        public virtual DbSet<ProgramEvents> ProgramEvents { get; set; }
        public virtual DbSet<Programs> Programs { get; set; }
        public virtual DbSet<ProgramsLog> ProgramsLog { get; set; }
        public virtual DbSet<ProspectApplicationInfo> ProspectApplicationInfo { get; set; }
        public virtual DbSet<ProspectEducationInfo> ProspectEducationInfo { get; set; }
        public virtual DbSet<ProspectGeneralInfo> ProspectGeneralInfo { get; set; }
        public virtual DbSet<ProspectPersonalInfo> ProspectPersonalInfo { get; set; }
        public virtual DbSet<ProspectProgramlar> ProspectProgramlar { get; set; }
        public virtual DbSet<QueryLogs> QueryLogs { get; set; }
        public virtual DbSet<Quotamen> Quotamen { get; set; }
        public virtual DbSet<RegIterations> RegIterations { get; set; }
        public virtual DbSet<RegistrationFlags> RegistrationFlags { get; set; }
        public virtual DbSet<RegStatus> RegStatus { get; set; }
        public virtual DbSet<Regulations> Regulations { get; set; }
        public virtual DbSet<RequestTypes> RequestTypes { get; set; }
        public virtual DbSet<ReservedRooms> ReservedRooms { get; set; }
        public virtual DbSet<RoleFunction> RoleFunction { get; set; }
        public virtual DbSet<RoleFunctionIp> RoleFunctionIp { get; set; }
        public virtual DbSet<Rolepages> Rolepages { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<SameCourses> SameCourses { get; set; }
        public virtual DbSet<ScheduleCampus> ScheduleCampus { get; set; }
        public virtual DbSet<ScheduleCampusSummer> ScheduleCampusSummer { get; set; }
        public virtual DbSet<ScheduleCampusTemp> ScheduleCampusTemp { get; set; }
        public virtual DbSet<ScheduleGroups> ScheduleGroups { get; set; }
        public virtual DbSet<ScheduleInstPref> ScheduleInstPref { get; set; }
        public virtual DbSet<ScheduleOwner> ScheduleOwner { get; set; }
        public virtual DbSet<Scholarship> Scholarship { get; set; }
        public virtual DbSet<ScoreTypes> ScoreTypes { get; set; }
        public virtual DbSet<SemesterGrades> SemesterGrades { get; set; }
        public virtual DbSet<SemesterLoads> SemesterLoads { get; set; }
        public virtual DbSet<SemesterOrder> SemesterOrder { get; set; }
        public virtual DbSet<Senator> Senator { get; set; }
        public virtual DbSet<SenatoTakip> SenatoTakip { get; set; }
        public virtual DbSet<Silinecek> Silinecek { get; set; }
        public virtual DbSet<SportsBranch> SportsBranch { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StandingParams> StandingParams { get; set; }
        public virtual DbSet<StatusValues> StatusValues { get; set; }
        public virtual DbSet<StuAflaGeriGelenler> StuAflaGeriGelenler { get; set; }
        public virtual DbSet<StuBackground> StuBackground { get; set; }
        public virtual DbSet<StuClub> StuClub { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentAddress> StudentAddress { get; set; }
        public virtual DbSet<StudentDormInfo> StudentDormInfo { get; set; }
        public virtual DbSet<StudentHomeAddress> StudentHomeAddress { get; set; }
        public virtual DbSet<StudentId> StudentId { get; set; }
        public virtual DbSet<StudentMilitary> StudentMilitary { get; set; }
        public virtual DbSet<StudentProgram> StudentProgram { get; set; }
        public virtual DbSet<StudentWork> StudentWork { get; set; }
        public virtual DbSet<StuDropped> StuDropped { get; set; }
        public virtual DbSet<StuErasmus> StuErasmus { get; set; }
        public virtual DbSet<StuHealth> StuHealth { get; set; }
        public virtual DbSet<StuLicence> StuLicence { get; set; }
        public virtual DbSet<StuMedicalHist> StuMedicalHist { get; set; }
        public virtual DbSet<StuMsbInfo> StuMsbInfo { get; set; }
        public virtual DbSet<StuMultipleTakenFor> StuMultipleTakenFor { get; set; }
        public virtual DbSet<StuOldUni> StuOldUni { get; set; }
        public virtual DbSet<StuOnLeave> StuOnLeave { get; set; }
        public virtual DbSet<StuOverPeriod> StuOverPeriod { get; set; }
        public virtual DbSet<StuPardoned> StuPardoned { get; set; }
        public virtual DbSet<StuPenalty> StuPenalty { get; set; }
        public virtual DbSet<StuPhDstatus> StuPhDstatus { get; set; }
        public virtual DbSet<StuRequest> StuRequest { get; set; }
        public virtual DbSet<StuScholarship> StuScholarship { get; set; }
        public virtual DbSet<StuSemester> StuSemester { get; set; }
        public virtual DbSet<StuSport> StuSport { get; set; }
        public virtual DbSet<StuSuny> StuSuny { get; set; }
        public virtual DbSet<StuTransfer> StuTransfer { get; set; }
        public virtual DbSet<StuVaccination> StuVaccination { get; set; }
        public virtual DbSet<Substitution> Substitution { get; set; }
        public virtual DbSet<SubstitutionStu> SubstitutionStu { get; set; }
        public virtual DbSet<SuggestedProgram> SuggestedProgram { get; set; }
        public virtual DbSet<SummerTuition> SummerTuition { get; set; }
        public virtual DbSet<TeamPlayers> TeamPlayers { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<TelCodes> TelCodes { get; set; }
        public virtual DbSet<Tips> Tips { get; set; }
        public virtual DbSet<TopAdministration> TopAdministration { get; set; }
        public virtual DbSet<TranscriptInfo> TranscriptInfo { get; set; }
        public virtual DbSet<Trccr> Trccr { get; set; }
        public virtual DbSet<Tuition> Tuition { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLog { get; set; }
        public virtual DbSet<UserLogs> UserLogs { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserTypes> UserTypes { get; set; }
        public virtual DbSet<UserWalkThrough> UserWalkThrough { get; set; }
        public virtual DbSet<ViolationTypes> ViolationTypes { get; set; }
        public virtual DbSet<WaitingApp> WaitingApp { get; set; }
        public virtual DbSet<Withdrawal> Withdrawal { get; set; }
        public virtual DbSet<WorkAile> WorkAile { get; set; }
        public virtual DbSet<WorkAileKisiler> WorkAileKisiler { get; set; }
        public virtual DbSet<WorkAileKonut> WorkAileKonut { get; set; }
        public virtual DbSet<WorkAileTasinmaz> WorkAileTasinmaz { get; set; }
        public virtual DbSet<WorkAileTasit> WorkAileTasit { get; set; }
        public virtual DbSet<WorkBasvuru> WorkBasvuru { get; set; }
        public virtual DbSet<WorkBasvuruAkademik> WorkBasvuruAkademik { get; set; }
        public virtual DbSet<WorkGelir> WorkGelir { get; set; }
        public virtual DbSet<WorkGelirBurs> WorkGelirBurs { get; set; }
        public virtual DbSet<WorkGenelBilgi> WorkGenelBilgi { get; set; }
        public virtual DbSet<WorkIkamet> WorkIkamet { get; set; }
        public virtual DbSet<WorkReferans> WorkReferans { get; set; }
        public virtual DbSet<WorkTasitStu> WorkTasitStu { get; set; }

        // Unable to generate entity type for table 'dbo.Semester_Loads_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Campus_Summer_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.No_Force_F_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Campus_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NGR_GRADING_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Substitution_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TransferSemesters_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TransferSemesters_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Schedule_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Violation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Schedule_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SecretQuestion_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Room_Summer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Courses_Offered'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SecretQuestion_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SecretQuestion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ParallelCo_Requisite_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Courses_Offered_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Param_PhDStatus_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Courses_Offered_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Parameter_Cities_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_AflaGeriGelenler_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Parameter_CityProvince_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Parameter_High_School_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Multiple_Taken_For_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_NEWOOC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PasswordChanger_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.KYK_YOP_KOD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Parameter_Year_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PasswordChanger_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.course_conflicts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FYK_UYK_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.progs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Quota_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Multiple_Taken_For_TRACE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Passcard_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Avoid_Maslak_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Dept_Consent_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Schedule_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Penalties_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Standing_Params_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Petition_Details_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Holds_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Quota_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.work_aile_kisiler_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Petition_Header_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.a'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ThesisAdvisor_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Room_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.work_aile_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Petition_Reviews_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.G'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Petition_Types_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Schedule_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Petitions_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Placement_Scores_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Penalty_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Changes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Turn_Off'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prerequisite_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PrerequisiteOR_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Programs_Log_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Master_Thesis_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prevent_Delete_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EFL_Courses_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Programs_Log_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_Summer_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Changes_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Proficiency_Scores_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.era_multi_sub'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DropType_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Sect_Pref_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FEB_Log_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DropType_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Sect_Pref_Summer_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_ID_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Events_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Supplement_SubTotals_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Background_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Course_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Query_Logs_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Course_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Background_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Role_Menus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Quotamen_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Authentication_Computers_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_ID_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Events_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Avoid_Maslak_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Co_requisite_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Minor_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Rapor_Say_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CCR_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Campus_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reg_Iterations_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Campus_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Registration_Flags_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Regulations_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sahin_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Grades_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Request_types_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prospect_Application_Info_Yedek'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.askerlikyazi_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reserved_Rooms_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CheckCategories_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prospect_Education_Info_Yedek'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Co_requisiteOR_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Results_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Class_Credits_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Over_Period_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prospect_Education_Uploads_Yedek'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.masterstudents_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Petition_Types'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Clubs_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Pardoned_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prospect_General_Info_Yedek'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Credit_Tuition_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RoleFunction_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Co_requisite_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prospect_Personal_Info_Yedek'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Room_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Co_requisiteOR_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_On_EFL_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Room_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ROLEPAGES_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.New_Students_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.stu_militaryinfo_masters'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Course_Desc_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Same_Courses_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.stu_militaryinfo_masters_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Credit_Tuition'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Role_Menus_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Electives_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Electives_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sinav'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Instructor_Address_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Old_Uni1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Double_Major_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sinav_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Zones'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Double_Major_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sinav_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Inst_Pref_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Quotamen_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Dept_Periods_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Owner_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Courses_Offered_Summer_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Sect_Pref_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Old_Uni1_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Courses_Offered_Summer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Derslik_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Prerequisite_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Course_Desc_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Rapor_Say'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Acad_Calendar_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Number_Parameter_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Derslik_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Grades_khk'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Substitution_Stu_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Number_Parameter'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Semester_Loads_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Osym_Prog_Codes_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Quota_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Dept_Power_Users_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Course_Groups_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Osym_Prog_Codes_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cum_Semester_khk'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reg_Iterations_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Schedule_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FYK_UYK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cum_AllSemester_khk'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pardoned6111_tmp_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Server_Access_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sports_Branch_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Activity_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dummy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pardoned6111_tmp_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reg_Status_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PrerequisiteOR_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Staff_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Favorite_Courses_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Top_Administration_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reg_Status_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hazirlikistek'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Parameter_Cities'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Form_Show_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Standing_Params_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Interest_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dandik'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Department_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Lang_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Registration_Flags_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HazirlikSinav_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Grades_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Membership_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Exemption_Coordinator_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HazirlikSinav_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Depts_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Personal_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Club_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Depts_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Skills_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Scholarship_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Semester_Grades_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Stu_Interest_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Server_Access'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Scholarship_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Semester_Grades_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Dropped_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Stu_Lang_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.printed_bachelors'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Health_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Stu_Personal_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Supplement_SubTotals'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Query'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Courses_Offered_Temp_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Licence_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Room_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Stu_Skills_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.work_genel_bilgi_trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_On_Leave_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Courses_Offered_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Medical_Hist_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReportColumns'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CV_Work_Experience_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_Summer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReportRelations'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Department_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Suny_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Roles_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReportTables'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Department_Registrar_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EFL_Condition'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Dept_Periods_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Suny_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GraduationDate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EFL_Condition_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Dept_Power_Users_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EFL_Condition_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DM_M_ApprovalStatus_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_PhDStatus_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Request_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Types_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Scholarship_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AccountingInfo_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Event_Types_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Scholarship_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Sport_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_GPA_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EFL_Tracks_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AccountingInfo_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Vaccination_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.stu_disability'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.stu_disability_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Event_Log_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Violation_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Announcements_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Schedule_Summer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Event_Types_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NGR_GRADING_TEMP_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Faculty_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_Home_Address_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TranscriptInfo_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Faculty_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_Course_Schedule_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FEB_Events_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GRADES_YEDEK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_Military_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Old_Course_Schedule_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sifre_changer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tuition_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Schedule_Summer_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Room_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Program_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Room_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Score_Types_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Violation_Types_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Program_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tuition_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.salla'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_Work_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Schedule_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Coming_Types_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Summer_Tuition_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.All_Programs_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Survey'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_On_EFL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Logs_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Schedule_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pardoned6111_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.All_Programs_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DoubleGrad'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sahin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Survey_Result'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Substitution_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Final_Exam_Schedule_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pardoned6111_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Groups_Temp_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DoubleGrad_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Substitution_Stu_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StuStates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Survey_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Current_Course_Schedule_Temp_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Suggested_Program_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Sect_Pref_Summer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EFL_Student_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Turn_Off_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Turn_Off_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Waiting_App_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FunctionDefinition_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Team_Players_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dandik_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Waiting_App_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Inst_Pref_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Teams_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Sect_Pref_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Transfer_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Semester_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TelCodes_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hrList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RoleFunctionIP_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.work_ikamet_trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ab'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_2006GRADS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_NEWOOC_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sched_list'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Grades_Symbols_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPCUR_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Survey_Result_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Instructor_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Loads_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Withdrawal_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Grades_Symbols_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Instructor_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Owner_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Loads_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Withdrawal_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GradesINTIBAK_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Old_Uni_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Campus_Temp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSMTelCodes_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Codes_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SemesterOrder_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Campus_Temp_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tips_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Instructor_Address_TRACE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.High_Schools_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Codes_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SemesterOrder_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sayilar'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Hold_Desc_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cum_Semester_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dummy2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Minor_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schedule_Sect_Pref_Temp_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Roles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ThesisAdvisor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GSM_Kontrol_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Holds_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Roles_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.work_gelir_burs_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Advisor_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Top_Administration_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Advisor_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Cum_AllSemester_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPCUR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Transfer_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Instructor_Office_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Ind_Training_Coordinator_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Programs_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.work_gelir_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Instructor_Office_TRACE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Ind_Training_Recent_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Standing_Types'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Program_Loads'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Standing_Types_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ClassListBim'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StateValues'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hatalar_trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Staff_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Instructor_Consents_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StateValues_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HSS_Codes_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Roles_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Supplement_Detail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Types_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IntibakAgreed_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StuStates_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.kimlikListesi1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserLoginLog_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Category_Type_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TransferSemesters'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Violation_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Last_GPA_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.vicefaculty'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Course_Types'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Violation_Types_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Last_Programs_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Student_Address_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Erasmus_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Course_Types_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.vicefaculty_trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Stu_Erasmus_Trace1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.vicefaculty_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Supplement_Detail_TRACE1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.No_Force_F_Trace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.News_TRACE1'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.;Database=TEST;user id=sa;password=Koralp8581;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountingInfo>(entity =>
            {
                entity.HasKey(e => new { e.Tarih, e.HesapKodu, e.Aciklama });
            });

            modelBuilder.Entity<Advisor>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.Advisor)
                    .HasForeignKey<Advisor>(d => d.StuId)
                    .HasConstraintName("FK_AdvisorStuIDStuID");
            });

            modelBuilder.Entity<AllPrograms>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode, e.Section, e.Origin });

                entity.Property(e => e.Section).IsUnicode(false);

                entity.Property(e => e.TakenFor).IsUnicode(false);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.AllPrograms)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_All_Programs_Course");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.AllPrograms)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_All_ProgramsStuIDStuID");
            });

            modelBuilder.Entity<Announcements>(entity =>
            {
                entity.Property(e => e.MsgDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsgFrom).IsUnicode(false);

                entity.Property(e => e.MsgType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Ann')");
            });

            modelBuilder.Entity<Askerlikyazi>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Asdate, e.Asyazi, e.Asil });
            });

            modelBuilder.Entity<AvoidMaslak>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.AvoidMaslak)
                    .HasForeignKey<AvoidMaslak>(d => d.StuId)
                    .HasConstraintName("FK_Avoid_MaslakStuIDStuID");
            });

            modelBuilder.Entity<BachelorPrint>(entity =>
            {
                entity.Property(e => e.ProgramId).ValueGeneratedNever();

                entity.HasOne(d => d.Program)
                    .WithOne(p => p.BachelorPrint)
                    .HasForeignKey<BachelorPrint>(d => d.ProgramId)
                    .HasConstraintName("FK_bachelor_print_Program_Depts");
            });

            modelBuilder.Entity<BursKategori>(entity =>
            {
                entity.Property(e => e.ScholarshipId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Scholarship)
                    .WithOne(p => p.BursKategori)
                    .HasForeignKey<BursKategori>(d => d.ScholarshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_burs_kategori_Scholarship");
            });

            modelBuilder.Entity<Ccr>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode, e.ProgramId });

                entity.HasIndex(e => e.LastGrade);

                entity.Property(e => e.History).IsUnicode(false);
            });

            modelBuilder.Entity<CcrDoubleTest>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode, e.ProgramId });

                entity.Property(e => e.History).IsUnicode(false);
            });

            modelBuilder.Entity<CheckCategories>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.CheckName });

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.CheckCategories)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckCategoriesDeptIDDeptID");
            });

            modelBuilder.Entity<ClassCredits>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.ProgramSemester });

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ClassCredits)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_CreditsProgramIDProgramID");
            });

            modelBuilder.Entity<ColInsertTrace>(entity =>
            {
                entity.Property(e => e.OperationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OperatorId).IsUnicode(false);

                entity.Property(e => e.TableName).IsUnicode(false);
            });

            modelBuilder.Entity<ComingTypes>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<CoRequisite>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.CoReq });
            });

            modelBuilder.Entity<CoRequisiteOr>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.CoReq });
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => new { e.CourseCode, e.CourseTitle, e.CourseCredit, e.CourseDept, e.Active })
                    .HasName("IX_Course");

                entity.Property(e => e.CourseCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<CourseDesc>(entity =>
            {
                entity.Property(e => e.CourseCode).ValueGeneratedNever();

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithOne(p => p.CourseDesc)
                    .HasForeignKey<CourseDesc>(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_DescCourse_CodeCourse_Code");
            });

            modelBuilder.Entity<CourseGroups>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.ProgramId });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.CourseGroups)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_GroupsCourse_CodeCourse_Code");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.CourseGroups)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_GroupsProgramIDProgramID");
            });

            modelBuilder.Entity<CourseRequirements>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Prereq, e.RequirementType });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.CourseRequirements)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRCourse_Code");
            });

            modelBuilder.Entity<CoursesOfferedSummer>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.Property(e => e.Exam).IsUnicode(false);

                entity.Property(e => e.OfferedTo).IsUnicode(false);

                entity.Property(e => e.Schedule).IsUnicode(false);
            });

            modelBuilder.Entity<CoursesOfferedTemp>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.Property(e => e.Exam).IsUnicode(false);

                entity.Property(e => e.OfferedTo).IsUnicode(false);

                entity.Property(e => e.RoomId).IsUnicode(false);

                entity.Property(e => e.Schedule).IsUnicode(false);
            });

            modelBuilder.Entity<CourseWebApiUsers>(entity =>
            {
                entity.Property(e => e.ApiKey).ValueGeneratedNever();
            });

            modelBuilder.Entity<CumAllSemester>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Year, e.Semester });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.CumAllSemester)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Cum_AllSemesterStuIDStuID");
            });

            modelBuilder.Entity<CumSemester>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Year, e.Semester });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.CumSemester)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Cum_SemesterStuIDStuID");
            });

            modelBuilder.Entity<CurrentAcadCalendar>(entity =>
            {
                entity.HasKey(e => new { e.AcadEventDate, e.AcadEvent });
            });

            modelBuilder.Entity<CurrentCourseQuota>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.Constraint, e.Group });

                entity.HasIndex(e => new { e.CourseCode, e.Section })
                    .HasName("NonClusteredIndex-20180208-140425");

                entity.Property(e => e.Constraint).IsUnicode(false);

                entity.Property(e => e.Group).IsUnicode(false);
            });

            modelBuilder.Entity<CurrentCourseQuotaSummer>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.Group });

                entity.Property(e => e.Group).IsUnicode(false);

                entity.Property(e => e.Constraint).IsUnicode(false);
            });

            modelBuilder.Entity<CurrentCourseQuotaTemp>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.Group });

                entity.Property(e => e.Group).IsUnicode(false);

                entity.Property(e => e.Constraint).IsUnicode(false);
            });

            modelBuilder.Entity<CurrentCourseSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.Day, e.Hour });

                entity.HasIndex(e => new { e.CourseCode, e.Section, e.Day, e.Hour, e.RoomId, e.OfferedTo, e.InstId })
                    .HasName("_dta_index_Current_Course_Schedule_5_1022678741__K3_1_2_4_5_6_7");

                entity.Property(e => e.Day).IsUnicode(false);

                entity.Property(e => e.Hour).IsUnicode(false);

                entity.Property(e => e.OfferedTo).IsUnicode(false);
            });

            modelBuilder.Entity<CurrentCourseScheduleSummer>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.Day, e.Hour });

                entity.Property(e => e.Day).IsUnicode(false);

                entity.Property(e => e.Hour).IsUnicode(false);

                entity.Property(e => e.OfferedTo).IsUnicode(false);
            });

            modelBuilder.Entity<CurrentCourseScheduleTemp>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.Day, e.Hour });

                entity.Property(e => e.Day).IsUnicode(false);

                entity.Property(e => e.Hour).IsUnicode(false);

                entity.Property(e => e.OfferedTo).IsUnicode(false);
            });

            modelBuilder.Entity<CvActivity>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Activity });

                entity.Property(e => e.Activity).IsUnicode(false);
            });

            modelBuilder.Entity<CvFavoriteCourses>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode });
            });

            modelBuilder.Entity<CvFormShow>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CvInterest>(entity =>
            {
                entity.Property(e => e.InterId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CvLang>(entity =>
            {
                entity.Property(e => e.LangId).ValueGeneratedNever();

                entity.Property(e => e.Language).IsUnicode(false);
            });

            modelBuilder.Entity<CvMembership>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.MemberOf });

                entity.Property(e => e.MemberOf).IsUnicode(false);
            });

            modelBuilder.Entity<CvPersonal>(entity =>
            {
                entity.Property(e => e.PersonalId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CvSkills>(entity =>
            {
                entity.Property(e => e.SkillId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CvStuInterest>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.InterId });
            });

            modelBuilder.Entity<CvStuLang>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.LangId });

                entity.Property(e => e.Level).IsUnicode(false);
            });

            modelBuilder.Entity<CvStuPersonal>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.PersonalId });
            });

            modelBuilder.Entity<CvStuSkills>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.SkillId });
            });

            modelBuilder.Entity<CvWorkExperience>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Company, e.EntryYear });

                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.EntryYear).IsUnicode(false);

                entity.Property(e => e.ExitYear).IsUnicode(false);

                entity.Property(e => e.Position).IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.HasOne(d => d.Fact)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.FactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentFactIDFactID");

                entity.HasOne(d => d.SecretaryNavigation)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.Secretary)
                    .HasConstraintName("FK_DepartmentSecretaryStaffID");
            });

            modelBuilder.Entity<DepartmentRegistrar>(entity =>
            {
                entity.HasKey(e => new { e.RegistrarId, e.DepartmentId });

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentRegistrar)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_RegistrarDepartmentIDDeptID");

                entity.HasOne(d => d.Registrar)
                    .WithMany(p => p.DepartmentRegistrar)
                    .HasForeignKey(d => d.RegistrarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_RegistrarRegistrarIDStaffID");
            });

            modelBuilder.Entity<DeptConsent>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.StuId });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.DeptConsent)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Dept_ConsentStuIDStuID");
            });

            modelBuilder.Entity<DeptPeriods>(entity =>
            {
                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.HasOne(d => d.Dept)
                    .WithOne(p => p.DeptPeriods)
                    .HasForeignKey<DeptPeriods>(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dept_PeriodsDeptIDDeptID");
            });

            modelBuilder.Entity<DeptPowerUsers>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.UserId });

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.DeptPowerUsers)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dept_Power_UsersDeptIDDeptID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeptPowerUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dept_Power_UsersUserIDStaffID");
            });

            modelBuilder.Entity<Derslik>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DiplomaSablon>(entity =>
            {
                entity.Property(e => e.ProgramId).ValueGeneratedNever();

                entity.HasOne(d => d.Program)
                    .WithOne(p => p.InverseProgram)
                    .HasForeignKey<DiplomaSablon>(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diploma_Sablon_Diploma_Sablon");

                entity.HasOne(d => d.ProgramNavigation)
                    .WithOne(p => p.DiplomaSablon)
                    .HasForeignKey<DiplomaSablon>(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diploma_Sablon_Program_Depts");
            });

            modelBuilder.Entity<DiplomaTaslak2017>(entity =>
            {
                entity.Property(e => e.ProgramId).ValueGeneratedNever();

                entity.HasOne(d => d.Program)
                    .WithOne(p => p.DiplomaTaslak2017)
                    .HasForeignKey<DiplomaTaslak2017>(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_diploma_taslak_2017_Program_Depts");
            });

            modelBuilder.Entity<DmMApprovalStatus>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.ApprovalStatus).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.DmMApprovalStatus)
                    .HasForeignKey<DmMApprovalStatus>(d => d.StuId)
                    .HasConstraintName("FK_DM_M_ApprovalStatusStuIDStuID");
            });

            modelBuilder.Entity<DoubleMajor>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.Dmaa).HasDefaultValueSql("('0000000000')");

                entity.Property(e => e.Dmadvisor).HasDefaultValueSql("('0000000000')");

                entity.Property(e => e.Dmfyk).HasDefaultValueSql("('0000000000')");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.DoubleMajor)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Double_Major_Program_Depts");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.DoubleMajor)
                    .HasForeignKey<DoubleMajor>(d => d.StuId)
                    .HasConstraintName("FK_Double_MajorStuIDStuID");
            });

            modelBuilder.Entity<DropType>(entity =>
            {
                entity.Property(e => e.DropType1).ValueGeneratedNever();
            });

            modelBuilder.Entity<EflCourses>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });
            });

            modelBuilder.Entity<EflStudent>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.EflStudent)
                    .HasForeignKey(d => d.TrackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFL_StudentTrackIDTrackID");
            });

            modelBuilder.Entity<EflTracks>(entity =>
            {
                entity.Property(e => e.TrackName).IsUnicode(false);
            });

            modelBuilder.Entity<EksikEvrak>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Electives>(entity =>
            {
                entity.HasKey(e => new { e.HssCode, e.CourseCode, e.DeptId });

                entity.Property(e => e.ElecTitle).IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Electives)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ElectivesDeptIDDeptID");
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.HasOne(d => d.EventTypeNavigation)
                    .WithMany(p => p.EventLog)
                    .HasForeignKey(d => d.EventType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_LogEvent_TypeEvent_Type");
            });

            modelBuilder.Entity<EventTypes>(entity =>
            {
                entity.Property(e => e.EventType).ValueGeneratedNever();

                entity.Property(e => e.EventDesc).IsUnicode(false);
            });

            modelBuilder.Entity<ExemptionCoordinator>(entity =>
            {
                entity.HasKey(e => new { e.InstId, e.CourseCode });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.ExemptionCoordinator)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exemption_CoordinatorCourse_CodeCourse_Code");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.Property(e => e.FactId).ValueGeneratedNever();

                entity.Property(e => e.GroupId).IsUnicode(false);

                entity.HasOne(d => d.SecretaryNavigation)
                    .WithMany(p => p.Faculty)
                    .HasForeignKey(d => d.Secretary)
                    .HasConstraintName("FK_FacultySecretaryStaffID");
            });

            modelBuilder.Entity<FebEvents>(entity =>
            {
                entity.Property(e => e.FebEventId).ValueGeneratedNever();
            });

            modelBuilder.Entity<FebLog>(entity =>
            {
                entity.HasOne(d => d.EventTypeNavigation)
                    .WithMany(p => p.FebLog)
                    .HasForeignKey(d => d.EventType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEB_LogEvent_TypeFEB_Event_ID");
            });

            modelBuilder.Entity<FinalExamRoom>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.ExamRoom });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.FinalExamRoom)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Final_Exam_RoomCourse_CodeCourse_Code");
            });

            modelBuilder.Entity<FinalExamSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.Property(e => e.ExamDate).IsUnicode(false);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.FinalExamSchedule)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Final_Exam_Schedule_Course");
            });

            modelBuilder.Entity<FinalGpa>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.FinalGpa)
                    .HasForeignKey<FinalGpa>(d => d.StuId)
                    .HasConstraintName("FK_Final_GPAStuIDStuID");
            });

            modelBuilder.Entity<FinalProgram>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode });

                entity.Property(e => e.TakenFor).IsUnicode(false);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.FinalProgram)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Final_ProgramCourse_CodeCourse_Code");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.FinalProgram)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Final_ProgramStuIDStuID");
            });

            modelBuilder.Entity<FunctionDefinition>(entity =>
            {
                entity.HasKey(e => new { e.FunctionId, e.PageName });

                entity.Property(e => e.PageName).IsUnicode(false);

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Grades>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.StuId, e.Year, e.Semester });

                entity.HasOne(d => d.LetterGradeNavigation)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.LetterGrade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradesLetter_GradeLetter_Grade");
            });

            modelBuilder.Entity<GradesIntibak>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.StuId, e.Year, e.Semester });
            });

            modelBuilder.Entity<GradesSymbols>(entity =>
            {
                entity.Property(e => e.LetterGrade).ValueGeneratedNever();
            });

            modelBuilder.Entity<GrsPuanTur>(entity =>
            {
                entity.Property(e => e.Kod)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmKontrol>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<GsmtelCodes>(entity =>
            {
                entity.Property(e => e.GsmtelCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<Hatalar>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<HazirlikSinav>(entity =>
            {
                entity.Property(e => e.Stuid).ValueGeneratedNever();
            });

            modelBuilder.Entity<HoldDesc>(entity =>
            {
                entity.Property(e => e.HoldType).ValueGeneratedNever();
            });

            modelBuilder.Entity<Holds>(entity =>
            {
                entity.HasOne(d => d.HoldTypeNavigation)
                    .WithMany(p => p.Holds)
                    .HasForeignKey(d => d.HoldType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoldsHold_TypeHold_Type");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.Holds)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_HoldsStuIDStuID");
            });

            modelBuilder.Entity<HssCodes>(entity =>
            {
                entity.Property(e => e.HssCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<IndTrainingCoordinator>(entity =>
            {
                entity.HasKey(e => new { e.InstId, e.CourseCode });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.IndTrainingCoordinator)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ind_Training_CoordinatorCourse_CodeCourse_Code");
            });

            modelBuilder.Entity<IndTrainingRecent>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.IndTrainingRecent)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Ind_Training_RecentStuIDStuID");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasIndex(e => new { e.InstFname, e.InstLname, e.InstId })
                    .HasName("_dta_index_Instructor_5_56439325__K1_2_4");

                entity.HasIndex(e => new { e.InstId, e.InstFname, e.InstMname, e.InstLname, e.InstTitle, e.DeptId })
                    .HasName("IX_Instructor");

                entity.Property(e => e.InstId).ValueGeneratedNever();
            });

            modelBuilder.Entity<InstructorAddress>(entity =>
            {
                entity.Property(e => e.InstId).ValueGeneratedNever();
            });

            modelBuilder.Entity<InstructorConsents>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.StuId });

                entity.Property(e => e.Section).IsUnicode(false);

                entity.Property(e => e.Consent).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.InstructorConsents)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Instructor_ConsentsStuIDStuID");
            });

            modelBuilder.Entity<InstructorOffice>(entity =>
            {
                entity.Property(e => e.InstId).ValueGeneratedNever();
            });

            modelBuilder.Entity<IntibakAgreed>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.ApproveDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.IntibakAgreed)
                    .HasForeignKey<IntibakAgreed>(d => d.StuId)
                    .HasConstraintName("FK_IntibakAgreedStuIDStuID");
            });

            modelBuilder.Entity<KhkOgrenciler>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<LastGpa>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<LastPrograms>(entity =>
            {
                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.HasOne(d => d.Dept)
                    .WithOne(p => p.LastPrograms)
                    .HasForeignKey<LastPrograms>(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Last_ProgramsDeptIDDeptID");

                entity.HasOne(d => d.LastProgramNavigation)
                    .WithMany(p => p.LastPrograms)
                    .HasForeignKey(d => d.LastProgram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Last_ProgramsLast_ProgramProgramID");
            });

            modelBuilder.Entity<MasterStudents>(entity =>
            {
                entity.Property(e => e.Stuid).ValueGeneratedNever();
            });

            modelBuilder.Entity<MasterThesis>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Minor>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.Maa).HasDefaultValueSql("('0000000000')");

                entity.Property(e => e.Madvisor).HasDefaultValueSql("('0000000000')");

                entity.Property(e => e.Mfyk).HasDefaultValueSql("('0000000000')");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Minor)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MinorProgramIDProgramID");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.Minor)
                    .HasForeignKey<Minor>(d => d.StuId)
                    .HasConstraintName("FK_MinorStuIDStuID");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId).ValueGeneratedNever();

                entity.Property(e => e.NewsText).IsUnicode(false);
            });

            modelBuilder.Entity<NewStudents>(entity =>
            {
                entity.Property(e => e.OsymNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<NoForceF>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.CourseCode, e.StuStatus });

                entity.Property(e => e.StuStatus).IsUnicode(false);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.NoForceF)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_No_Force_FProgramIDProgramID");
            });

            modelBuilder.Entity<OldCourseSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section, e.Year, e.Semester, e.Day, e.Hour });

                entity.Property(e => e.Semester).IsUnicode(false);

                entity.Property(e => e.Day).IsUnicode(false);

                entity.Property(e => e.Hour).IsUnicode(false);

                entity.Property(e => e.OfferedTo).IsUnicode(false);
            });

            modelBuilder.Entity<OsymProgCodes>(entity =>
            {
                entity.Property(e => e.ProgramCode).IsUnicode(false);
            });

            modelBuilder.Entity<OsymYerlesen>(entity =>
            {
                entity.Property(e => e.Tc).ValueGeneratedNever();

                entity.Property(e => e.ProgramCode).IsUnicode(false);
            });

            modelBuilder.Entity<ParallelCoRequisite>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.CoReq });
            });

            modelBuilder.Entity<ParameterCityProvince>(entity =>
            {
                entity.Property(e => e.SubProvinceId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.SubProvince).IsUnicode(false);
            });

            modelBuilder.Entity<ParameterHighSchool>(entity =>
            {
                entity.Property(e => e.Schoolid).ValueGeneratedOnAdd();

                entity.Property(e => e.SchoolName).IsUnicode(false);
            });

            modelBuilder.Entity<ParameterYear>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.Semester });
            });

            modelBuilder.Entity<ParamPhDstatus>(entity =>
            {
                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusText).IsUnicode(false);
            });

            modelBuilder.Entity<Pardoned6111>(entity =>
            {
                entity.Property(e => e.Stuid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pardoned6111Tmp>(entity =>
            {
                entity.HasKey(e => new { e.Stuid, e.Deptid });
            });

            modelBuilder.Entity<PartTimeInstructorInstitution>(entity =>
            {
                entity.Property(e => e.InstId).ValueGeneratedNever();

                entity.Property(e => e.Institution).IsUnicode(false);

                entity.HasOne(d => d.Inst)
                    .WithOne(p => p.PartTimeInstructorInstitution)
                    .HasForeignKey<PartTimeInstructorInstitution>(d => d.InstId)
                    .HasConstraintName("FK_Part_Time_Instructor_InstitutionInstIDInstID");
            });

            modelBuilder.Entity<Passcard>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.Passcard)
                    .HasForeignKey<Passcard>(d => d.StuId)
                    .HasConstraintName("FK_PasscardStuIDStuID");
            });

            modelBuilder.Entity<PasswordChanger>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Year, e.Semester });
            });

            modelBuilder.Entity<Penalties>(entity =>
            {
                entity.Property(e => e.PenaltyDesc).IsUnicode(false);
            });

            modelBuilder.Entity<PetitionDetails>(entity =>
            {
                entity.Property(e => e.Petdata).IsUnicode(false);

                entity.Property(e => e.Pettext).IsUnicode(false);
            });

            modelBuilder.Entity<PetitionHeader>(entity =>
            {
                entity.Property(e => e.Processresult).HasDefaultValueSql("(0)");

                entity.Property(e => e.Processresulttext).IsUnicode(false);

                entity.Property(e => e.StuId).IsUnicode(false);
            });

            modelBuilder.Entity<PetitionReviews>(entity =>
            {
                entity.HasKey(e => new { e.Petitiondetailid, e.Reviewertype });

                entity.Property(e => e.Reviewertype).IsUnicode(false);

                entity.Property(e => e.Reviewerid).IsUnicode(false);
            });

            modelBuilder.Entity<Petitions>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.PetitionType, e.PetitionDate });
            });

            modelBuilder.Entity<PlacementScores>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.State).IsUnicode(false);

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.PlacementScores)
                    .HasForeignKey<PlacementScores>(d => d.StuId)
                    .HasConstraintName("FK_Placement_ScoresStuIDStuID");
            });

            modelBuilder.Entity<Prerequisite>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Prereq });
            });

            modelBuilder.Entity<PrerequisiteOr>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Prereq });
            });

            modelBuilder.Entity<PreventDelete>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.PreventDelete)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Prevent_DeleteStuIDStuID");
            });

            modelBuilder.Entity<ProficiencyScores>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.State).IsUnicode(false);

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.ProficiencyScores)
                    .HasForeignKey<ProficiencyScores>(d => d.StuId)
                    .HasConstraintName("FK_Proficiency_ScoresStuIDStuID");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.CourseCode });

                entity.Property(e => e.Ects).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ProgramNavigation)
                    .WithMany(p => p.Program)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Program_Program_Depts");
            });

            modelBuilder.Entity<ProgramCodes>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.YokBirim });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Language).IsUnicode(false);

                entity.Property(e => e.ProgramCode).IsUnicode(false);
            });

            modelBuilder.Entity<ProgramDepts>(entity =>
            {
                entity.Property(e => e.ProgramId).ValueGeneratedNever();

                entity.Property(e => e.ProgramLevel).IsUnicode(false);

                entity.Property(e => e.Visibility).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.ProgramDepts)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_Program_DeptsDeptIDDeptID");
            });

            modelBuilder.Entity<ProgramEvents>(entity =>
            {
                entity.Property(e => e.ProgramEventId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Programs>(entity =>
            {
                entity.Property(e => e.ProgramId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProgramsLog>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.ProgramEventDate, e.ProgramEventId });

                entity.HasOne(d => d.ProgramEvent)
                    .WithMany(p => p.ProgramsLog)
                    .HasForeignKey(d => d.ProgramEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Programs_LogProgram_Event_IDProgram_Event_ID");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.ProgramsLog)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Programs_LogStuIDStuID");
            });

            modelBuilder.Entity<ProspectApplicationInfo>(entity =>
            {
                entity.Property(e => e.StuIdNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProspectEducationInfo>(entity =>
            {
                entity.Property(e => e.StuIdNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProspectGeneralInfo>(entity =>
            {
                entity.Property(e => e.StuIdNo).ValueGeneratedNever();

                entity.Property(e => e.ProgramCode).IsUnicode(false);
            });

            modelBuilder.Entity<ProspectPersonalInfo>(entity =>
            {
                entity.Property(e => e.StuIdNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProspectProgramlar>(entity =>
            {
                entity.Property(e => e.Sira).ValueGeneratedNever();
            });

            modelBuilder.Entity<Quotamen>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<RegIterations>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Period });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.RegIterations)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Reg_IterationsStuIDStuID");
            });

            modelBuilder.Entity<RegistrationFlags>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.RegistrationFlags)
                    .HasForeignKey<RegistrationFlags>(d => d.StuId)
                    .HasConstraintName("FK_Registration_FlagsStuIDStuID");
            });

            modelBuilder.Entity<RegStatus>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RegStatus)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reg_Status_Status_Values");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.RegStatus)
                    .HasForeignKey<RegStatus>(d => d.StuId)
                    .HasConstraintName("FK_Reg_Status_Student");
            });

            modelBuilder.Entity<Regulations>(entity =>
            {
                entity.HasKey(e => new { e.Referans, e.DeptId });

                entity.Property(e => e.ArticleNo).IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Regulations)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegulationsDeptIDDeptID");
            });

            modelBuilder.Entity<RequestTypes>(entity =>
            {
                entity.Property(e => e.ReqId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ReservedRooms>(entity =>
            {
                entity.HasKey(e => new { e.RoomId, e.Date, e.Hour });

                entity.Property(e => e.Hour).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReservedRooms)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reserved_RoomsUserIDStaffID");
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
                entity.HasKey(e => new { e.FunctionName, e.FunctionRole });

                entity.Property(e => e.FunctionRole).IsUnicode(false);

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FunctionId).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipprotected).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<RoleFunctionIp>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UserRole, e.RoleFunction, e.Ip });

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.UserRole).IsUnicode(false);

                entity.Property(e => e.Ip).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Rolepages>(entity =>
            {
                entity.HasKey(e => new { e.RoleName, e.PageName });

                entity.Property(e => e.RoleName).IsUnicode(false);

                entity.Property(e => e.PageName).IsUnicode(false);

                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SameCourses>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.SameCourse });
            });

            modelBuilder.Entity<ScheduleCampus>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.HasIndex(e => new { e.CourseCode, e.Section, e.Campus })
                    .HasName("IX_Schedule_Campus");

                entity.Property(e => e.Campus).IsUnicode(false);
            });

            modelBuilder.Entity<ScheduleCampusSummer>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.Property(e => e.Campus).IsUnicode(false);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.ScheduleCampusSummer)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_Campus_Summer_Course");
            });

            modelBuilder.Entity<ScheduleCampusTemp>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.Property(e => e.Campus).IsUnicode(false);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.ScheduleCampusTemp)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_Campus_TempCourse_CodeCourse_Code");
            });

            modelBuilder.Entity<ScheduleGroups>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.CourseCode, e.Section });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.ScheduleGroups)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_GroupsCourse_CodeCourse_Code");
            });

            modelBuilder.Entity<ScheduleInstPref>(entity =>
            {
                entity.HasKey(e => new { e.InstId, e.Day, e.Hour });

                entity.Property(e => e.Day).IsUnicode(false);

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.ScheduleInstPref)
                    .HasForeignKey(d => d.InstId)
                    .HasConstraintName("FK_Schedule_Inst_PrefInstIDInstID");
            });

            modelBuilder.Entity<ScheduleOwner>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Section });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.ScheduleOwner)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_OwnerCourse_CodeCourse_Code");
            });

            modelBuilder.Entity<ScoreTypes>(entity =>
            {
                entity.Property(e => e.ScoreCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<SemesterGrades>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.StuId });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.SemesterGrades)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Semester_GradesCourse_CodeCourse_Code");

                entity.HasOne(d => d.GradeNavigation)
                    .WithMany(p => p.SemesterGrades)
                    .HasForeignKey(d => d.Grade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Semester_GradesGradeLetter_Grade");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.SemesterGrades)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Semester_GradesStuIDStuID");
            });

            modelBuilder.Entity<SemesterLoads>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.ProgramSemester });

                entity.Property(e => e.ProgramSemester).IsUnicode(false);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.SemesterLoads)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Semester_LoadsProgramIDProgramID");
            });

            modelBuilder.Entity<SemesterOrder>(entity =>
            {
                entity.Property(e => e.Semester).ValueGeneratedNever();
            });

            modelBuilder.Entity<Senator>(entity =>
            {
                entity.Property(e => e.ProgramId).ValueGeneratedNever();

                entity.HasOne(d => d.Program)
                    .WithOne(p => p.Senator)
                    .HasForeignKey<Senator>(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Senator_Senator");
            });

            modelBuilder.Entity<Silinecek>(entity =>
            {
                entity.HasKey(e => new { e.Stuid, e.CourseCode });

                entity.Property(e => e.Stuid).IsUnicode(false);

                entity.Property(e => e.TakenFor).IsUnicode(false);
            });

            modelBuilder.Entity<SportsBranch>(entity =>
            {
                entity.Property(e => e.BranchName).IsUnicode(false);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.StaffId).ValueGeneratedNever();
            });

            modelBuilder.Entity<StandingParams>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.Standing });

                entity.Property(e => e.Standing).IsUnicode(false);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.StandingParams)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Standing_ParamsProgramIDProgramID");
            });

            modelBuilder.Entity<StatusValues>(entity =>
            {
                entity.Property(e => e.StatusId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StuAflaGeriGelenler>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<StuBackground>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.OssProgCode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NotAssigned')");

                entity.Property(e => e.OssScoreType).IsUnicode(false);

                entity.Property(e => e.SuccessRank).IsUnicode(false);

                entity.HasOne(d => d.ComingTypeNavigation)
                    .WithMany(p => p.StuBackground)
                    .HasForeignKey(d => d.ComingType)
                    .HasConstraintName("FK_Stu_Background_Coming_Types");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.InverseStu)
                    .HasForeignKey<StuBackground>(d => d.StuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stu_Background_Stu_Background");

                entity.HasOne(d => d.StuNavigation)
                    .WithOne(p => p.StuBackground)
                    .HasForeignKey<StuBackground>(d => d.StuId)
                    .HasConstraintName("FK_Stu_BackgroundStuIDStuID");
            });

            modelBuilder.Entity<StuClub>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Club });

                entity.HasOne(d => d.ClubNavigation)
                    .WithMany(p => p.StuClub)
                    .HasForeignKey(d => d.Club)
                    .HasConstraintName("FK_Stu_Club_Clubs");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.StuClub)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Stu_ClubStuIDStuID");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => new { e.StuId, e.DeptId, e.ProgramEntrySemester, e.ProgramId, e.StuStanding, e.ProgramEntryYear, e.StuFname, e.StuLname, e.StuMname })
                    .HasName("IX_Student");

                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.ProgramEntrySemester).IsUnicode(false);
            });

            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.City).HasDefaultValueSql("(N'ISTANBUL')");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.StudentAddress)
                    .HasForeignKey<StudentAddress>(d => d.StuId)
                    .HasConstraintName("FK_Student_AddressStuIDStuID");
            });

            modelBuilder.Entity<StudentDormInfo>(entity =>
            {
                entity.HasKey(e => new { e.Stuid, e.Year, e.Semester, e.DropType });

                entity.HasOne(d => d.StudentDormInfoNavigation)
                    .WithOne(p => p.InverseStudentDormInfoNavigation)
                    .HasForeignKey<StudentDormInfo>(d => new { d.Stuid, d.Year, d.Semester, d.DropType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_student_dorm_info_student_dorm_info");
            });

            modelBuilder.Entity<StudentHomeAddress>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.StudentHomeAddress)
                    .HasForeignKey<StudentHomeAddress>(d => d.StuId)
                    .HasConstraintName("FK_Student_Home_AddressStuIDStuID");
            });

            modelBuilder.Entity<StudentId>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.Eesicilkendi).IsUnicode(false);

                entity.Property(e => e.Eesicilsag).IsUnicode(false);

                entity.Property(e => e.Eesicilyar).IsUnicode(false);

                entity.Property(e => e.StuFamilyNo).IsUnicode(false);

                entity.Property(e => e.StuOrderNo).IsUnicode(false);

                entity.Property(e => e.StuRegistNo).IsUnicode(false);

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.StudentId)
                    .HasForeignKey<StudentId>(d => d.StuId)
                    .HasConstraintName("FK_Student_IDStuIDStuID");
            });

            modelBuilder.Entity<StudentMilitary>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.StudentMilitary)
                    .HasForeignKey<StudentMilitary>(d => d.StuId)
                    .HasConstraintName("FK_Student_MilitaryStuIDStuID");
            });

            modelBuilder.Entity<StudentProgram>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode, e.Origin });

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.TakenFor).IsUnicode(false);
            });

            modelBuilder.Entity<StudentWork>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<StuDropped>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.StuDropped)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_Stu_DroppedDeptIDDeptID");

                entity.HasOne(d => d.DropTypeNavigation)
                    .WithMany(p => p.StuDropped)
                    .HasForeignKey(d => d.DropType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Stu_Dropped_DropType");

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.StuDropped)
                    .HasForeignKey<StuDropped>(d => d.StuId)
                    .HasConstraintName("FK_Stu_DroppedStuIDStuID");
            });

            modelBuilder.Entity<StuErasmus>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Year, e.Semester });
            });

            modelBuilder.Entity<StuHealth>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<StuLicence>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Club, e.Branch });

                entity.Property(e => e.Club).IsUnicode(false);

                entity.HasOne(d => d.BranchNavigation)
                    .WithMany(p => p.StuLicence)
                    .HasForeignKey(d => d.Branch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stu_LicenceBranchBranchID");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.StuLicence)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Stu_Licence_Student");
            });

            modelBuilder.Entity<StuMedicalHist>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.RecordText, e.Age });
            });

            modelBuilder.Entity<StuMsbInfo>(entity =>
            {
                entity.HasKey(e => new { e.City, e.Msb });
            });

            modelBuilder.Entity<StuMultipleTakenFor>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode, e.TakenFor });

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.StuMultipleTakenFor)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stu_Multiple_Taken_For_Course");
            });

            modelBuilder.Entity<StuOldUni>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Institution, e.Faculty, e.Department });
            });

            modelBuilder.Entity<StuOnLeave>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Year, e.Semester });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.StuOnLeave)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Stu_On_LeaveStuIDStuID");
            });

            modelBuilder.Entity<StuOverPeriod>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.StuOverPeriod)
                    .HasForeignKey<StuOverPeriod>(d => d.StuId)
                    .HasConstraintName("FK_Stu_Over_PeriodStuIDStuID");
            });

            modelBuilder.Entity<StuPardoned>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.StuPardoned)
                    .HasForeignKey<StuPardoned>(d => d.StuId)
                    .HasConstraintName("FK_Stu_PardonedStuIDStuID");
            });

            modelBuilder.Entity<StuPenalty>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.PenaltyId, e.PenaltyDate });

                entity.HasOne(d => d.Penalty)
                    .WithMany(p => p.StuPenalty)
                    .HasForeignKey(d => d.PenaltyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stu_PenaltyPenaltyIDPenaltyID");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.StuPenalty)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Stu_PenaltyStuIDStuID");
            });

            modelBuilder.Entity<StuPhDstatus>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.Insertdatetime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StuRequest>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.ReqId, e.Date });

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.StuRequest)
                    .HasForeignKey(d => d.ReqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stu_RequestReqIDReqID");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.StuRequest)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Stu_RequestStuIDStuID");
            });

            modelBuilder.Entity<StuScholarship>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.ScholarshipId, e.Year, e.Semester });

                entity.Property(e => e.Semester).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.RecordId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Scholarship)
                    .WithMany(p => p.StuScholarship)
                    .HasForeignKey(d => d.ScholarshipId)
                    .HasConstraintName("FK_Stu_ScholarshipScholarshipIDScholarshipID");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.StuScholarship)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Stu_ScholarshipStuIDStuID");
            });

            modelBuilder.Entity<StuSemester>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<StuSport>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.GarmentSize).IsUnicode(false);

                entity.Property(e => e.TrainingRegularity).IsUnicode(false);

                entity.HasOne(d => d.BranchNavigation)
                    .WithMany(p => p.StuSport)
                    .HasForeignKey(d => d.Branch)
                    .HasConstraintName("FK_Stu_SportBranchBranchID");
            });

            modelBuilder.Entity<StuSuny>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.Year, e.Semester });
            });

            modelBuilder.Entity<StuTransfer>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.TransType });

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.StuTransfer)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Stu_TransferStuIDStuID");
            });

            modelBuilder.Entity<StuVaccination>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.VaccName, e.VaccNo });

                entity.Property(e => e.VaccName).IsUnicode(false);
            });

            modelBuilder.Entity<Substitution>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.CourseCode, e.Substitute });

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Substitution)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_SubstitutionProgramIDProgramID");
            });

            modelBuilder.Entity<SubstitutionStu>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Substitute, e.StuId });
            });

            modelBuilder.Entity<SuggestedProgram>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode });

                entity.Property(e => e.TakenFor).IsUnicode(false);

                entity.HasOne(d => d.CourseCodeNavigation)
                    .WithMany(p => p.SuggestedProgram)
                    .HasForeignKey(d => d.CourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suggested_ProgramCourse_CodeCourse_Code");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.SuggestedProgram)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK_Suggested_ProgramStuIDStuID");
            });

            modelBuilder.Entity<SummerTuition>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.SummerTuition)
                    .HasForeignKey<SummerTuition>(d => d.StuId)
                    .HasConstraintName("FK_Summer_TuitionStuIDStuID");
            });

            modelBuilder.Entity<TeamPlayers>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.TeamId });

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamPlayers)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_PlayersTeamIDTeamID");
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.Property(e => e.TeamName).IsUnicode(false);
            });

            modelBuilder.Entity<TelCodes>(entity =>
            {
                entity.Property(e => e.TelCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tips>(entity =>
            {
                entity.Property(e => e.TipText).IsUnicode(false);
            });

            modelBuilder.Entity<TopAdministration>(entity =>
            {
                entity.Property(e => e.InstId).ValueGeneratedNever();

                entity.Property(e => e.AdminType).IsUnicode(false);

                entity.HasOne(d => d.Inst)
                    .WithOne(p => p.TopAdministration)
                    .HasForeignKey<TopAdministration>(d => d.InstId)
                    .HasConstraintName("FK_Top_AdministrationInstIDInstID");
            });

            modelBuilder.Entity<TranscriptInfo>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.Property(e => e.Birthplacedate).IsUnicode(false);

                entity.Property(e => e.DateGraduated).IsUnicode(false);

                entity.Property(e => e.DateRegistered).IsUnicode(false);

                entity.Property(e => e.DegreeAwarded).IsUnicode(false);

                entity.Property(e => e.DoubleMajor).IsUnicode(false);

                entity.Property(e => e.Eflenterance).IsUnicode(false);

                entity.Property(e => e.Eflexitance).IsUnicode(false);

                entity.Property(e => e.Eflgrade).IsUnicode(false);

                entity.Property(e => e.GraduationStanding).IsUnicode(false);

                entity.Property(e => e.HighSchool).IsUnicode(false);

                entity.Property(e => e.Major).IsUnicode(false);

                entity.Property(e => e.Minor).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Trccr>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();

                entity.HasOne(d => d.Stu)
                    .WithOne(p => p.Trccr)
                    .HasForeignKey<Trccr>(d => d.StuId)
                    .HasConstraintName("FK_TRCCR_Student");
            });

            modelBuilder.Entity<Tuition>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.Year });
            });

            modelBuilder.Entity<UserLoginLog>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.EntranceDate });

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.EntranceDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserLogs>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.EventTypeNavigation)
                    .WithMany(p => p.UserLogs)
                    .HasForeignKey(d => d.EventType)
                    .HasConstraintName("FK_User_LogsEvent_Typeevent_type");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UserRole });
            });

            modelBuilder.Entity<UserTypes>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserWalkThrough>(entity =>
            {
                entity.Property(e => e.EntranceDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PageName).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<ViolationTypes>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.Violation, e.StuStatus, e.StuStanding, e.Period, e.GpaLimit });

                entity.Property(e => e.GpaLimit).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WaitingApp>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Withdrawal>(entity =>
            {
                entity.HasKey(e => new { e.StuId, e.CourseCode, e.Year, e.Semester });
            });

            modelBuilder.Entity<WorkAile>(entity =>
            {
                entity.Property(e => e.Stuid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkAileKonut>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkBasvuru>(entity =>
            {
                entity.Property(e => e.Stuid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkBasvuruAkademik>(entity =>
            {
                entity.Property(e => e.Stuid).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkGelir>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkGenelBilgi>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkIkamet>(entity =>
            {
                entity.Property(e => e.StuId).ValueGeneratedNever();
            });
        }
    }
}
