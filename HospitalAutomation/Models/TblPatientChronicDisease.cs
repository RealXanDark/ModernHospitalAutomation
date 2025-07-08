using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblPatientChronicDisease
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public int ChronicDiseaseId { get; set; }

    public DateTime DiagnosisDate { get; set; }

    public bool IsActive { get; set; }

    public virtual TblChronicDisease ChronicDisease { get; set; } = null!;

    public virtual TblPatient Patient { get; set; } = null!;
}
