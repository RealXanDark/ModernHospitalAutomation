using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblIdentityNumber
{
    public int IdentityNumberId { get; set; }

    public byte[] IdentityNumber { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual TblPatient? TblPatient { get; set; }

    public virtual TblUser? TblUser { get; set; }
}
