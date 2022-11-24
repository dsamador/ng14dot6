using FullStack.API.Data;
using FullStack.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EmployeesController : Controller
  {
    private readonly FullStackDbContext db;

    public EmployeesController(FullStackDbContext db)
    {
      this.db = db;
    }

    [HttpGet]    
    public async Task<IActionResult> GetAllEmployees()
    {
      var employees = await db.Employees.ToListAsync();

      return Ok(employees);
    }

    [HttpPost]    
    public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest)
    {
      employeeRequest.Id = Guid.NewGuid();
      await db.Employees.AddAsync(employeeRequest);
      await db.SaveChangesAsync();

      return Ok(employeeRequest);
    }
  }
}
