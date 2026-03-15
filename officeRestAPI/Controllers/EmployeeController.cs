using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using officeRestAPI.Models;

namespace officeRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly OfficeContext context;

        public EmployeeController(OfficeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> getEmployee()
        {
            var data = await context.Employees.ToListAsync();
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> getEmployeeById(int id)
        {
            var data = await context.Employees.FindAsync(id);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> createEmployee(Employee employee)
        {
            await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> updateEmployee(int id,Employee employee)
        {
           
            if (id != employee.Id)
            {
                return NotFound();
            }
            context.Entry(employee).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> removeEmployee(int id)
        {
            var data = await context.Employees.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            context.Employees.Remove(data);
            await context.SaveChangesAsync();
            return Ok(data);
        }
    }
}
