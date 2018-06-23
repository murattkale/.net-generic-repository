using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    public partial class Withdrawal
    {
        [Column("StuID")]
        [StringLength(11)]
        public string StuId { get; set; }
        [Column("Course_Code")]
        [StringLength(13)]
        public string CourseCode { get; set; }
        public int Year { get; set; }
        [StringLength(8)]
        public string Semester { get; set; }
        [Column("Withdraw_Date", TypeName = "datetime")]
        public DateTime? WithdrawDate { get; set; }
    }
}
