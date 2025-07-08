using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Models
{
    public class LocationInfo
    {
        public string? ip { get; set; }
        public string? city { get; set; }
        public string? loc { get; set; }
        public string? country { get; set; }// "latitude,longitude"
    }
}
