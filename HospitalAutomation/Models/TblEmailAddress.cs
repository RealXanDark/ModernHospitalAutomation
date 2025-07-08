using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblEmailAddress
{
    public int EmailId { get; set; }

    public byte[] Email { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual ICollection<TblEmailAccount> TblEmailAccounts { get; set; } = new List<TblEmailAccount>();

    public virtual TblPatient? TblPatient { get; set; }
}
