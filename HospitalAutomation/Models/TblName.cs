using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblName
{
    public int NameId { get; set; }

    public byte[] Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual ICollection<TblPatient> TblPatients { get; set; } = new List<TblPatient>();
}
