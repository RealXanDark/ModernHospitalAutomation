using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblHospitalClinic
{
    public int HospitalClinicId { get; set; }

    public int HospitalId { get; set; }

    public int ClinicId { get; set; }

    public string ClinicPhoneNumber { get; set; } = null!;

    public bool ClinicIsActive { get; set; }

    public virtual TblClinic Clinic { get; set; } = null!;

    public virtual TblHospital Hospital { get; set; } = null!;

    public virtual ICollection<TblAppointment> TblAppointments { get; set; } = new List<TblAppointment>();

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual ICollection<TblHospitalRoom> TblHospitalRooms { get; set; } = new List<TblHospitalRoom>();

    public virtual ICollection<TblVisit> TblVisits { get; set; } = new List<TblVisit>();
}
