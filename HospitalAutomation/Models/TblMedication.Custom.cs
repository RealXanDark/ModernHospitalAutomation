using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Models
{
    public partial class TblMedication
    {
        [NotMapped]
        public byte Quantity { get; set; }

        public string cbName => $"{MedicationType} - {MedicationName}";

        public string lbName => $"{Quantity} adet - {MedicationName}";
    }
}
