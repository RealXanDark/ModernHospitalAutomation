using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblAppointmentTime
{
    public int AppointmentTimeId { get; set; }

    public TimeOnly AppointmentTime { get; set; }

    public virtual ICollection<TblAppointment> TblAppointments { get; set; } = new List<TblAppointment>();
}
