using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblSupportTicket
{
    public int TicketId { get; set; }

    public string MacAddress { get; set; } = null!;

    public long UserIdentityNo { get; set; }

    public byte? Status { get; set; }

    public byte RequestTypeId { get; set; }

    public string IssueDescription { get; set; } = null!;

    public DateTime? IssueDate { get; set; }

    public string? Response { get; set; }

    public DateTime LastUpdate { get; set; }

    public DateTime? ResolvedDate { get; set; }

    public int? AssignedTo { get; set; }

    public virtual TblRequestType RequestType { get; set; } = null!;
}
