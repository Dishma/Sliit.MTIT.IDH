using System.Reflection;

namespace Employee.Data
{
    public class EmployeeMockDataService
    {
        public static List<Models.Employee> Employees = new List<Models.Employee>()
        {
            new Models.Employee{ Id=1, Name="Thisara", Email="tisara@gmail.com", PhoneNumber="0123456789", Speciality="Cardiology", Gender="female", Availability="Yes"},
            new Models.Employee{ Id=2, Name="Charya", Email="charya@gmail.com", PhoneNumber="0125478965", Speciality = "Dermatology", Gender="female", Availability="Yes"},
            new Models.Employee{ Id=3, Name="Sayuri", Email="sayuri@gmail.com", PhoneNumber="0235847581", Speciality = "Hematology", Gender="female", Availability = "No"},
            new Models.Employee{ Id=4, Name="Chandrawansa", Email="chandra@gmail.com", PhoneNumber="0215365478", Speciality = "Neurology", Gender="male", Availability="Yes"},
            new Models.Employee{ Id=5, Name="Karunanayaka", Email="Karuna@gmail.com", PhoneNumber="0321235125", Speciality = "Pediatrics", Gender="male", Availability = "Yes"},
        };
    }
}
