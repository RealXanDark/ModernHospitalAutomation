using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblBloodGroup
{
    public byte BloodGroupId { get; set; }

    public string BloodGroupName { get; set; } = null!;

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual ICollection<TblPatient> TblPatients { get; set; } = new List<TblPatient>();
}
