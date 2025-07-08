using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblRequestType
{
    public byte RequestTypeId { get; set; }

    public string RequestTypeName { get; set; } = null!;

    public virtual ICollection<TblSupportTicket> TblSupportTickets { get; set; } = new List<TblSupportTicket>();
}
