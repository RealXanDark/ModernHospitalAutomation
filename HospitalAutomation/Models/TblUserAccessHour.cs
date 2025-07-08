using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblUserAccessHour
{
    public byte UserTypeId { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }
}
