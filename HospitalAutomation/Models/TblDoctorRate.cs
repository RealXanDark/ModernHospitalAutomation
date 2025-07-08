using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblDoctorRate
{
    public int RateId { get; set; }

    public int DoctorId { get; set; }

    public int TotalRating { get; set; }

    public int TotalRatingCount { get; set; }

    public virtual TblDoctor Doctor { get; set; } = null!;
}
