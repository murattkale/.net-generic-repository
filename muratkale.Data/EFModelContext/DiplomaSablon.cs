using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Diploma_Sablon")]
    public partial class DiplomaSablon
    {
        [Key]
        [Column("ProgramID")]
        [StringLength(25)]
        public string ProgramId { get; set; }
        [Column("DeptID")]
        [StringLength(5)]
        public string DeptId { get; set; }
        [Column("FactID", TypeName = "nchar(10)")]
        public string FactId { get; set; }
        [Column("alan_fakülte")]
        [StringLength(100)]
        public string AlanFakülte { get; set; }
        [Column("ana_bilim")]
        [StringLength(150)]
        public string AnaBilim { get; set; }
        [Column("Alan_Program")]
        [StringLength(100)]
        public string AlanProgram { get; set; }
        [Column("alan_Program_diploma")]
        [StringLength(100)]
        public string AlanProgramDiploma { get; set; }
        [Column("alan_onay")]
        [StringLength(50)]
        public string AlanOnay { get; set; }
        [Column("alan_bachelor")]
        [StringLength(200)]
        public string AlanBachelor { get; set; }
        [Column("alan_faculty")]
        [StringLength(100)]
        public string AlanFaculty { get; set; }
        [Column("Ortak_Dean_Title")]
        [StringLength(20)]
        public string OrtakDeanTitle { get; set; }
        [Column("Ortak_Dean_Name")]
        [StringLength(50)]
        public string OrtakDeanName { get; set; }
        [Column("Ortak_Dekan_Unv")]
        [StringLength(20)]
        public string OrtakDekanUnv { get; set; }
        [Column("Ortak_Dekan_İsim")]
        [StringLength(50)]
        public string OrtakDekanİsim { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("InverseProgram")]
        public DiplomaSablon Program { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("DiplomaSablon")]
        public ProgramDepts ProgramNavigation { get; set; }
        [InverseProperty("Program")]
        public DiplomaSablon InverseProgram { get; set; }
    }
}
