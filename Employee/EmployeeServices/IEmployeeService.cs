namespace Employee.Services
{
    public interface IEmployeeService
    {
        List<Models.Employee> GetEmployees();
        Models.Employee? GetEmployee(int id);
        Models.Employee? AddEmployee(Models.Employee employee);
        Models.Employee? UpdateEmployee(Models.Employee employee);
        bool? DeleteEmployee(int id);
    }
}
