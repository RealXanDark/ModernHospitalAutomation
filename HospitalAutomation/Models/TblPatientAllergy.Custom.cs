using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HospitalAutomation.frmTest;

namespace HospitalAutomation.Models
{
    public partial class TblPatientAllergy
    {
        [NotMapped]
        public string DisplayName
        {
            get
            {
                if (Allergy == null)
                {
                    return string.Empty;
                }

                var displayText = (IsNew ? "Yeni Eklenen - " : DiagnosisDate.ToString("dd.MM.yyyy") + " - ") + Allergy.AllergyName;

                if (IsDeleted)
                {
                    displayText += " (silindi)";
                }

                return displayText;
            }
        }

        [NotMapped]
        public bool IsNew { get; set; }

        [NotMapped]
        public bool IsDeleted { get; set; }
    }
}
