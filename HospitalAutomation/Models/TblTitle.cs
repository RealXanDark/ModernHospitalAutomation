using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblTitle
{
    public byte TitleId { get; set; }

    public string TitleName { get; set; } = null!;

    public string? TitleDescription { get; set; }

    public virtual ICollection<TblDoctor> TblDoctors { get; set; } = new List<TblDoctor>();
}
