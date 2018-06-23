using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muratkale.Data.EFModelContext
{
    [Table("Current_Acad_Calendar")]
    public partial class CurrentAcadCalendar
    {
        [Column("Acad_Event_Date", TypeName = "datetime")]
        public DateTime AcadEventDate { get; set; }
        [Column("Acad_Event")]
        [StringLength(100)]
        public string AcadEvent { get; set; }
    }
}
