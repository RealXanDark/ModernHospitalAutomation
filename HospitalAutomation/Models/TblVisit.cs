using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblVisit
{
    public int VisitId { get; set; }

    public int HospitalId { get; set; }

    public int ClinicId { get; set; }

    public int AppointmentId { get; set; }

    public int DoctorId { get; set; }

    public int PatientId { get; set; }

    public DateTime VisitDate { get; set; }

    public byte? Rates { get; set; }

    public string? Diagnosis { get; set; }

    public string? Notes { get; set; }

    public string? Comment { get; set; }

    public virtual TblAppointment Appointment { get; set; } = null!;

    public virtual TblHospitalClinic Clinic { get; set; } = null!;

    public virtual TblDoctor Doctor { get; set; } = null!;

    public virtual TblHospital Hospital { get; set; } = null!;

    public virtual TblPatient Patient { get; set; } = null!;
}
