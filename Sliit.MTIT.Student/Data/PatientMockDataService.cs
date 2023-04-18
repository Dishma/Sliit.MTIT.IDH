using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Reflection;

namespace Patient.Data
{
    public class PatientMockDataService
    {
        public static List<Models.Patient> Patients = new List<Models.Patient>()
        {
            new Models.Patient{ Id=1, Name="John", Address="123 Main St", Age=21},
            new Models.Patient{ Id=2, Name="Mary", Address="456 Second Ave", Age=22},
            new Models.Patient{ Id=3, Name="Tom", Address="789 Third St", Age=25},
            new Models.Patient{ Id=4, Name="Kate", Address="13 Main St", Age=24},
            new Models.Patient{ Id=5, Name="Mike", Address="78 Temple St", Age=23},
        };
    }
}
