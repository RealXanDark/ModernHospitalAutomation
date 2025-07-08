using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblProvince
{
    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; } = null!;

    public bool ProvinceHasBranch { get; set; }

    public int? ProvinceAreaCode { get; set; }

    public virtual ICollection<TblHospital> TblHospitals { get; set; } = new List<TblHospital>();
}
