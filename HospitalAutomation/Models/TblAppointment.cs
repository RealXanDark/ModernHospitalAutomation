using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblAppointment
{
    public int AppointmentId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public int HospitalId { get; set; }

    public int ClinicId { get; set; }

    public DateOnly AppointmentDate { get; set; }

    public int AppointmentTimeId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int UpdatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual TblAppointmentTime AppointmentTime { get; set; } = null!;

    public virtual TblHospitalClinic Clinic { get; set; } = null!;

    public virtual TblDoctor Doctor { get; set; } = null!;

    public virtual TblHospital Hospital { get; set; } = null!;

    public virtual TblPatient Patient { get; set; } = null!;

    public virtual TblAppointmentStatus Status { get; set; } = null!;

    public virtual ICollection<TblPrescription> TblPrescriptions { get; set; } = new List<TblPrescription>();

    public virtual ICollection<TblTestResult> TblTestResults { get; set; } = new List<TblTestResult>();

    public virtual ICollection<TblVisit> TblVisits { get; set; } = new List<TblVisit>();
}
