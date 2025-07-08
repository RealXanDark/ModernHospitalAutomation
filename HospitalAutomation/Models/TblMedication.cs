using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblMedication
{
    public int MedicationId { get; set; }

    public string MedicationName { get; set; } = null!;

    public string MedicationType { get; set; } = null!;

    public virtual ICollection<TblPrescription> TblPrescriptions { get; set; } = new List<TblPrescription>();
}
