using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblErrorLog
{
    public int ErrorId { get; set; }

    public string MacAddress { get; set; } = null!;

    public string? ErrorMessage { get; set; }

    public string? ErrorStack { get; set; }

    public DateTime? ErrorDate { get; set; }
}
