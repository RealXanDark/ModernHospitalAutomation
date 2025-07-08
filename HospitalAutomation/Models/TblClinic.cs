using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblClinic
{
    public int ClinicId { get; set; }

    public string ClinicName { get; set; } = null!;

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual ICollection<TblHospitalClinic> TblHospitalClinics { get; set; } = new List<TblHospitalClinic>();
}
