using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblAppointmentStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public string? StatusDescription { get; set; }

    public virtual ICollection<TblAppointment> TblAppointments { get; set; } = new List<TblAppointment>();
}
