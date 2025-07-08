using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblTest
{
    public int TestId { get; set; }

    public string TestName { get; set; } = null!;

    public double? MinValueMale { get; set; }

    public double? MaxValueMale { get; set; }

    public double? MinValueFemale { get; set; }

    public double? MaxValueFemale { get; set; }

    public virtual ICollection<TblTestResult> TblTestResults { get; set; } = new List<TblTestResult>();
}
