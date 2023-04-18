using Employee.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService??throw new ArgumentException(nameof(employeeService));
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeeService.GetEmployees());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _employeeService.GetEmployee(id) != null ? Ok(_employeeService.GetEmployee(id)) : NoContent();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Employee employee)
        {
            return Ok(_employeeService.AddEmployee(employee));
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Employee employee)
        {
            return Ok(_employeeService.UpdateEmployee(employee));
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _employeeService.DeleteEmployee(id);

            return result.HasValue & result == true ? Ok($"employee with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the employee with ID:{id}");
        }
    }
}
