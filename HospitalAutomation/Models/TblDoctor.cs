using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblDoctor
{
    public int DoctorId { get; set; }

    public int IdentityNumberId { get; set; }

    public byte[] FirstName { get; set; } = null!;

    public byte[] LastName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public bool Gender { get; set; }

    public byte BloodGroupId { get; set; }

    public int PhoneNumberId { get; set; }

    public int EmailId { get; set; }

    public int SpecialtyId { get; set; }

    public int ClinicId { get; set; }

    public int HospitalId { get; set; }

    public byte TitleId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsRestrictionExempt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual TblBloodGroup BloodGroup { get; set; } = null!;

    public virtual TblHospitalClinic Clinic { get; set; } = null!;

    public virtual TblEmailAddress Email { get; set; } = null!;

    public virtual TblHospital Hospital { get; set; } = null!;

    public virtual TblIdentityNumber IdentityNumber { get; set; } = null!;

    public virtual TblPhoneNumber PhoneNumber { get; set; } = null!;

    public virtual TblClinic Specialty { get; set; } = null!;

    public virtual ICollection<TblAppointment> TblAppointments { get; set; } = new List<TblAppointment>();

    public virtual ICollection<TblDoctorRate> TblDoctorRates { get; set; } = new List<TblDoctorRate>();

    public virtual ICollection<TblHospitalRoom> TblHospitalRooms { get; set; } = new List<TblHospitalRoom>();

    public virtual ICollection<TblPrescription> TblPrescriptions { get; set; } = new List<TblPrescription>();

    public virtual ICollection<TblTestResult> TblTestResults { get; set; } = new List<TblTestResult>();

    public virtual ICollection<TblVisit> TblVisits { get; set; } = new List<TblVisit>();

    public virtual TblTitle Title { get; set; } = null!;
}
