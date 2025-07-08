using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblDistrict
{
    public int DistrictId { get; set; }

    public string DistrictName { get; set; } = null!;

    public int DistrictParentId { get; set; }

    public bool DistrictHasBranch { get; set; }

    public virtual ICollection<TblHospital> TblHospitals { get; set; } = new List<TblHospital>();
}
