using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using officeRestAPI.Models;

namespace officeRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly OfficeContext context;

        public DepartmentController(OfficeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> getDepartment()
        {
            var data = await context.Departments.ToListAsync();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> getDeparmentById(int id)
        {
            var data = await context.Departments.FindAsync(id);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<Department>> createDepartment(Department department)
        {
            await context.Departments.AddAsync(department);
            await context.SaveChangesAsync();
            return Ok(department);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Department>> updateDepartment(int id, Department department)
        {
            
            if (id != department.Id)
            {
                return NotFound();
            }
            context.Entry(department).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(department);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> removeDepartment(int id)
        {
            var data = await context.Departments.FindAsync(id);
            if (data == null)
            {
                return BadRequest();
            }
            context.Departments.Remove(data);
            await context.SaveChangesAsync();
            return Ok(data);
        }
    }
}
