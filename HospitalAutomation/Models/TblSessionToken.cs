using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblSessionToken
{
    public int TokenId { get; set; }

    public int UserId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime TokenCreatedAt { get; set; }

    public bool TokenIsActive { get; set; }

    public DateTime? TokenExpiresAt { get; set; }

    public virtual TblUser User { get; set; } = null!;
}
