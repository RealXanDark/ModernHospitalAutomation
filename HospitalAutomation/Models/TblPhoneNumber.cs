using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblPhoneNumber
{
    public int PhoneNumberId { get; set; }

    public byte[] PhoneNumber { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual TblPatient? TblPatient { get; set; }
}
