using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblHospitalRoom
{
    public int RoomId { get; set; }

    public int HospitalId { get; set; }

    public int ClinicId { get; set; }

    public int DoctorId { get; set; }

    public short RoomNumber { get; set; }

    public byte FloorNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual TblHospitalClinic Clinic { get; set; } = null!;

    public virtual TblDoctor Doctor { get; set; } = null!;

    public virtual TblHospital Hospital { get; set; } = null!;
}
