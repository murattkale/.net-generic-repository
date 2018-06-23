using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Old_Course_Schedule")]
    public partial class OldCourseSchedule
    {
        [Column("Course_Code")]
        [StringLength(20)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        public int Year { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [StringLength(2)]
        public string Day { get; set; }
        [StringLength(2)]
        public string Hour { get; set; }
        [Column("RoomID")]
        [StringLength(10)]
        public string RoomId { get; set; }
        [Column("Offered_To")]
        [StringLength(500)]
        public string OfferedTo { get; set; }
    }
}
