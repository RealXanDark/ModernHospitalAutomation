using System;
using System.Collections.Generic;

namespace HospitalAutomation.Models;

public partial class TblPatientAllergy
{
    public int Id { get; set; }

    public int AllergyId { get; set; }

    public int PatientId { get; set; }

    public DateTime DiagnosisDate { get; set; }

    public bool IsActive { get; set; }

    public virtual TblAllergy Allergy { get; set; } = null!;

    public virtual TblPatient Patient { get; set; } = null!;
}
