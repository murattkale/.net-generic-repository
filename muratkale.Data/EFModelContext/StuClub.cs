using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Stu_Club")]
    public partial class StuClub
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        public int Club { get; set; }
        [StringLength(50)]
        public string Rank { get; set; }

        [ForeignKey("Club")]
        [InverseProperty("StuClub")]
        public Clubs ClubNavigation { get; set; }
        [ForeignKey("StuId")]
        [InverseProperty("StuClub")]
        public Student Stu { get; set; }
    }
}
