using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblBlacklist
{
    public int BlacklistId { get; set; }

    public byte BlockType { get; set; }

    public string? DeviceMacAddress { get; set; }

    public long? UserIdentityNumber { get; set; }

    public string Reason { get; set; } = null!;

    public DateTime? AddedAt { get; set; }

    public bool? IsActive { get; set; }
}
