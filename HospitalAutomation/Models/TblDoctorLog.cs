using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblDoctorLog
{
    public int Id { get; set; }

    public int? SessionId { get; set; }

    public int UserId { get; set; }

    public string ActivityType { get; set; } = null!;

    public byte[]? ActivityParameters { get; set; }

    public DateTime Datetime { get; set; }
}
