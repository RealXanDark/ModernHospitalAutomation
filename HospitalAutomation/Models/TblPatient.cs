using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblPatient
{
    public int PatientId { get; set; }

    public int IdentityNumberId { get; set; }

    public byte[] FirstName { get; set; } = null!;

    public byte[] LastName { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public int EmailId { get; set; }

    public int PhoneNumberId { get; set; }

    public bool Gender { get; set; }

    public byte BloodGroupId { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual TblBloodGroup BloodGroup { get; set; } = null!;

    public virtual TblEmailAddress Email { get; set; } = null!;

    public virtual TblIdentityNumber IdentityNumber { get; set; } = null!;

    public virtual TblPhoneNumber PhoneNumber { get; set; } = null!;

    public virtual ICollection<TblAppointment> TblAppointments { get; set; } = new List<TblAppointment>();

    public virtual ICollection<TblPatientAllergy> TblPatientAllergies { get; set; } = new List<TblPatientAllergy>();

    public virtual ICollection<TblPatientChronicDisease> TblPatientChronicDiseases { get; set; } = new List<TblPatientChronicDisease>();

    public virtual ICollection<TblPrescription> TblPrescriptions { get; set; } = new List<TblPrescription>();

    public virtual ICollection<TblTestResult> TblTestResults { get; set; } = new List<TblTestResult>();

    public virtual ICollection<TblVisit> TblVisits { get; set; } = new List<TblVisit>();
}
