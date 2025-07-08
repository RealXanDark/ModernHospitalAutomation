using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblEmailAccount
{
    public int EmailAccountId { get; set; }

    public int UserId { get; set; }

    public int EmailAddressId { get; set; }

    public byte[] FirstName { get; set; } = null!;

    public byte[] LastName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual TblEmailAddress EmailAddress { get; set; } = null!;

    public virtual ICollection<TblHospitalMail> TblHospitalMailReceivers { get; set; } = new List<TblHospitalMail>();

    public virtual ICollection<TblHospitalMail> TblHospitalMailSenders { get; set; } = new List<TblHospitalMail>();

    public virtual TblUser User { get; set; } = null!;
}
