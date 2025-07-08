using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblAllergy
{
    public int AllergyId { get; set; }

    public string AllergyName { get; set; } = null!;

    public virtual ICollection<TblPatientAllergy> TblPatientAllergies { get; set; } = new List<TblPatientAllergy>();
}
