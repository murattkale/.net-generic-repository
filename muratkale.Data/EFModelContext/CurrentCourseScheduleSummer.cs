using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Current_Course_Schedule_Summer")]
    public partial class CurrentCourseScheduleSummer
    {
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Required]
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [StringLength(2)]
        public string Day { get; set; }
        [StringLength(2)]
        public string Hour { get; set; }
        [Required]
        [Column("RoomID")]
        [StringLength(10)]
        public string RoomId { get; set; }
        [Column("Offered_To")]
        [StringLength(150)]
        public string OfferedTo { get; set; }
    }
}
