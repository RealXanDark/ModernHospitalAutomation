using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblTestResult
{
    public int ResultId { get; set; }

    public DateTime TestRequestDate { get; set; }

    public int AppointmentId { get; set; }

    public int TestId { get; set; }

    public int DoctorId { get; set; }

    public int PatientId { get; set; }

    public double? TestResult { get; set; }

    public string? Notes { get; set; }

    public bool DoctorControl { get; set; }

    public DateTime? ResultDate { get; set; }

    public virtual TblAppointment Appointment { get; set; } = null!;

    public virtual TblDoctor Doctor { get; set; } = null!;

    public virtual TblPatient Patient { get; set; } = null!;

    public virtual TblTest Test { get; set; } = null!;
}
