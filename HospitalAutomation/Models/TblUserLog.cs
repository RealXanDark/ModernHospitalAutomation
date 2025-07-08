using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblUserLog
{
    public int LogId { get; set; }

    public int LogUserId { get; set; }

    public string LogAction { get; set; } = null!;

    public DateTime LogActionDate { get; set; }

    public string LogActionDetails { get; set; } = null!;

    public virtual TblUser LogUser { get; set; } = null!;
}
