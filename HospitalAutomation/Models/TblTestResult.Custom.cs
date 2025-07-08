using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Models
{
    public partial class TblTestResult
    {
        [NotMapped]
        public DateTime AddedDate { get; set; }
    }
}
