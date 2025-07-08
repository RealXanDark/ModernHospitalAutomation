using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public int IdentityNumberId { get; set; }

    public byte[] Password { get; set; } = null!;

    public byte TypeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? TempIdentityNumber { get; set; }

    public string? TempPassword { get; set; }

    public virtual TblIdentityNumber IdentityNumber { get; set; } = null!;

    public virtual ICollection<TblEmailAccount> TblEmailAccounts { get; set; } = new List<TblEmailAccount>();

    public virtual ICollection<TblSessionToken> TblSessionTokens { get; set; } = new List<TblSessionToken>();

    public virtual ICollection<TblUserSessionLog> TblUserSessionLogs { get; set; } = new List<TblUserSessionLog>();

    public virtual TblUserType Type { get; set; } = null!;
}
