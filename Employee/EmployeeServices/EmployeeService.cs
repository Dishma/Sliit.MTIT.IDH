using Employee.Data;
using Employee.Models;

namespace Employee.Services
{
    
        public class EmployeeService : IEmployeeService
        {
            public List<Models.Employee> GetEmployees()
            {
                return EmployeeMockDataService.Employees;
            }

            public Models.Employee? GetEmployee(int id)
            {
                return EmployeeMockDataService.Employees.FirstOrDefault(x => x.Id == id);
            }

            public Models.Employee? AddEmployee(Models.Employee employee)
            {
                EmployeeMockDataService.Employees.Add(employee);
                return employee;
            }

            public Models.Employee? UpdateEmployee(Models.Employee employee)
            {
                Models.Employee selectedEmployee = EmployeeMockDataService.Employees.FirstOrDefault(x => x.Id == employee.Id);
                if (selectedEmployee != null)
                {
                    selectedEmployee.Name = employee.Name;
                    selectedEmployee.Email = employee.Email;
                    selectedEmployee.PhoneNumber = employee.PhoneNumber;
                    selectedEmployee.Speciality = employee.Speciality;
                    selectedEmployee.Gender = employee.Gender;
                    selectedEmployee.Availability = employee.Availability;
                    return selectedEmployee;
                }
                return selectedEmployee;
            }

            public bool? DeleteEmployee(int id)
            {
                Models.Employee selectemployee = EmployeeMockDataService.Employees.FirstOrDefault(x => x.Id == id);
                if(selectemployee != null)
                {
                    EmployeeMockDataService.Employees.Remove(selectemployee);
                    return true;
                }
                return false;
            }

            
        }
    
}
