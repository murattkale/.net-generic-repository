using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Reserved_Rooms")]
    public partial class ReservedRooms
    {
        [Column("RoomID")]
        [StringLength(10)]
        public string RoomId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [StringLength(2)]
        public string Hour { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("ReservedRooms")]
        public Staff User { get; set; }
    }
}
