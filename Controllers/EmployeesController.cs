using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        List<Employee> employees = new List<Employee>();

        public EmployeesController()
        {
            employees.Add(new Employee { EmpId = 1, Name = "Mridul Singh", Email = "mriduls@chetu.com", Address = "Noida" });
            employees.Add(new Employee { EmpId = 2, Name = "X Singh", Email = "x@chetu.com", Address = "Noida" });
            employees.Add(new Employee { EmpId = 3, Name = "Y Singh", Email = "y@chetu.com", Address = "Delhi" });
            employees.Add(new Employee { EmpId = 4, Name = "Z Singh", Email = "z@chetu.com", Address = "Noida" });
            employees.Add(new Employee { EmpId = 5, Name = "P Singh", Email = "p@chetu.com", Address = "GZB" });
        }

        // GET: api/Employees
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            Employee employee= employees.FirstOrDefault(emp => emp.EmpId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST: api/Employees
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            employees.Add(employee);
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
