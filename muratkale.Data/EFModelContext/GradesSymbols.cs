using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Grades_Symbols")]
    public partial class GradesSymbols
    {
        public GradesSymbols()
        {
            Grades = new HashSet<Grades>();
            SemesterGrades = new HashSet<SemesterGrades>();
        }

        [Key]
        [Column("Letter_Grade")]
        [StringLength(10)]
        public string LetterGrade { get; set; }
        [Column("Numeric_Value")]
        public float NumericValue { get; set; }
        [Required]
        [Column("Grade_Desc")]
        [StringLength(20)]
        public string GradeDesc { get; set; }

        [InverseProperty("LetterGradeNavigation")]
        public ICollection<Grades> Grades { get; set; }
        [InverseProperty("GradeNavigation")]
        public ICollection<SemesterGrades> SemesterGrades { get; set; }
    }
}
