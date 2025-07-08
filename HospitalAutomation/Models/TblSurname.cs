using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblSurname
{
    public int SurnameId { get; set; }

    public byte[] Surname { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();

    public virtual ICollection<TblPatient> TblPatients { get; set; } = new List<TblPatient>();
}
