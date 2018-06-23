using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Room
    {
        [Column("RoomID")]
        [StringLength(10)]
        public string RoomId { get; set; }
        [Column("Room_Description")]
        [StringLength(50)]
        public string RoomDescription { get; set; }
        [Column("Room_Capacity")]
        public int? RoomCapacity { get; set; }
        [StringLength(10)]
        public string Building { get; set; }
        [StringLength(50)]
        public string Campus { get; set; }
        [Column("Room_Type")]
        [StringLength(50)]
        public string RoomType { get; set; }
        [Column("Exam_Capacity")]
        public int? ExamCapacity { get; set; }
    }
}
