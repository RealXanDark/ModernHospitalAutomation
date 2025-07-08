using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblFailedLoginAttempt
{
    public int AttemptId { get; set; }

    public string MacAddress { get; set; } = null!;

    public DateTime AttemptTime { get; set; }
}
