using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Instructor_Office")]
    public partial class InstructorOffice
    {
        [Key]
        [Column("InstID")]
        [StringLength(10)]
        public string InstId { get; set; }
        [Required]
        [Column("RoomID")]
        [StringLength(10)]
        public string RoomId { get; set; }
        [Required]
        [Column("Phone_Ext")]
        [StringLength(20)]
        public string PhoneExt { get; set; }
        [Column("Secretary_Ext")]
        [StringLength(20)]
        public string SecretaryExt { get; set; }
    }
}
