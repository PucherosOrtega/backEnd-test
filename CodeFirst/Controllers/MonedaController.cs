using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private DatabaseContext _context;

        public MonedaController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<Moneda>>> GetMonedas()
        {
            if(_context.Monedas == null)
            {
                return NotFound();
            }
            return await  _context.Monedas.ToListAsync();
        }
    }
}
