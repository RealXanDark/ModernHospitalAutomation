using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblHospitalMail
{
    public int MailId { get; set; }

    public int SenderId { get; set; }

    public int ReceiverId { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public DateTime SentDateTime { get; set; }

    public bool IsRead { get; set; }

    public virtual TblEmailAccount Receiver { get; set; } = null!;

    public virtual TblEmailAccount Sender { get; set; } = null!;
}
