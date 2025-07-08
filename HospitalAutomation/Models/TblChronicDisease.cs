using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblChronicDisease
{
    public int ChronicDiseaseId { get; set; }

    public string DiseaseName { get; set; } = null!;

    public bool AlertRequired { get; set; }

    public virtual ICollection<TblPatientChronicDisease> TblPatientChronicDiseases { get; set; } = new List<TblPatientChronicDisease>();
}
