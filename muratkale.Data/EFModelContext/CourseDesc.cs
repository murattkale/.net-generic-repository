using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Course_Desc")]
    public partial class CourseDesc
    {
        [Key]
        [Column("Course_Code")]
        [StringLength(50)]
        public string CourseCode { get; set; }
        [Required]
        [Column("Course_Description")]
        public string CourseDescription { get; set; }
        [Column("Course_Title_Eng")]
        [StringLength(135)]
        public string CourseTitleEng { get; set; }
        [Column("Course_Description_Tur")]
        public string CourseDescriptionTur { get; set; }
        [Column("Course_Title_Tur")]
        [StringLength(135)]
        public string CourseTitleTur { get; set; }

        [ForeignKey("CourseCode")]
        [InverseProperty("CourseDesc")]
        public Course CourseCodeNavigation { get; set; }
    }
}
