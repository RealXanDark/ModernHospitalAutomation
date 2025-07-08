using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblHospital
{
    public int HospitalId { get; set; }

    public string HospitalName { get; set; } = null!;

    public string HospitalPhoneNumber { get; set; } = null!;

    public string HospitalAddress { get; set; } = null!;

    public int HospitalProvinceId { get; set; }

    public int HospitalDistrictId { get; set; }

    public bool HospitalIsActive { get; set; }

    public virtual TblDistrict HospitalDistrict { get; set; } = null!;

    public virtual TblProvince HospitalProvince { get; set; } = null!;

    public virtual ICollection<TblAppointment> TblAppointments { get; set; } = new List<TblAppointment>();

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual ICollection<TblHospitalClinic> TblHospitalClinics { get; set; } = new List<TblHospitalClinic>();

    public virtual ICollection<TblHospitalRoom> TblHospitalRooms { get; set; } = new List<TblHospitalRoom>();

    public virtual ICollection<TblVisit> TblVisits { get; set; } = new List<TblVisit>();
}
