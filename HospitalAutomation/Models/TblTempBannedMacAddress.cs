using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblTempBannedMacAddress
{
    public int TempBanId { get; set; }

    public string MacAddress { get; set; } = null!;

    public DateTime BanStartTime { get; set; }

    public DateTime BanEndTime { get; set; }
}
