using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblPrescription
{
    public int Id { get; set; }

    public int AppointmentId { get; set; }

    public int DoctorId { get; set; }

    public int PatientId { get; set; }

    public int MedicationId { get; set; }

    public byte MedicationQuantity { get; set; }

    public DateTime PrescriptionCreationDate { get; set; }

    public virtual TblAppointment Appointment { get; set; } = null!;

    public virtual TblDoctor Doctor { get; set; } = null!;

    public virtual TblMedication Medication { get; set; } = null!;

    public virtual TblPatient Patient { get; set; } = null!;
}
