using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciboController : ControllerBase
    {
        private DatabaseContext _context;

        public ReciboController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recibo>>> GetRecibos()
        //public async Task<ActionResult<Array>> GetRecibos()
        {
            if (_context.Reciboes == null)
            {
                return NotFound();
            }
            var returnArray = from cols in _context.Reciboes
                              from c in _context.Monedas
                              where cols.monedaID == c.monedaID
                              select new { 
                                monedaID = cols.monedaID,
                                monedaName = c.monedaName,
                                reciboID = cols.reciboID,
                                proveedorID= cols.proveedorID,
                                date = cols.date,
                                comentario = cols.comentario,
                                monto = cols.monto,
                                userID = cols.userID,
                              };
            return await _context.Reciboes.ToListAsync();
            //return await _context.Reciboes.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Recibo>> PostRecibo (Recibo recibo)
        {
            _context.Reciboes.Add(recibo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecibos), new { id = recibo.reciboID }, recibo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutRecibo (int id,Recibo recibo)
        {
            if(id != recibo.reciboID)
            {
                return BadRequest();
            }
            _context.Entry(recibo).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }catch(DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRecibo (int id)
        {
            if(_context.Reciboes == null)
            {
                return NotFound();
            }
            var recibo= await _context.Reciboes.FindAsync(id);
            if(recibo == null)
            {
                return NotFound();
            }
            _context.Reciboes.Remove(recibo);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
