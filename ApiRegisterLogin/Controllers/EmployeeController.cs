using ApiRegisterLogin.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRegisterLogin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _appDbContext.Employee.ToListAsync());
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllByName([FromQuery] string name)
        {
            return Ok(await _appDbContext.Employee.Where(m => m.FullName == name).ToListAsync());
        }
    }
}
