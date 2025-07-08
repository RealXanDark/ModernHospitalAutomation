using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Models
{
    public partial class TblDoctor
    {
        public string DoctorFullName => $"{Title?.TitleName ?? ""} {Capitalize(Encryption.Decrypt(FirstName))} {Capitalize(Encryption.Decrypt(LastName))}";


        private string Capitalize(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }
    }
}
