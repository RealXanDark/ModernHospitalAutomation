using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblUserSessionLog
{
    public int SessionId { get; set; }

    public int UserId { get; set; }

    public string MacAddress { get; set; } = null!;

    public string? IpAddress { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Location { get; set; }

    public string SessionToken { get; set; } = null!;

    public DateTime LoginTime { get; set; }

    public DateTime? LogoutTime { get; set; }

    public long? SessionDuration { get; set; }

    public virtual TblUser User { get; set; } = null!;
}
