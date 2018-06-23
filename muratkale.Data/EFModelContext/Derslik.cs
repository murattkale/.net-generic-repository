using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Derslik
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("RoomID")]
        [StringLength(10)]
        public string RoomId { get; set; }
        [Column("Exam_Capacity")]
        public int ExamCapacity { get; set; }
        public int Sold { get; set; }
    }
}
