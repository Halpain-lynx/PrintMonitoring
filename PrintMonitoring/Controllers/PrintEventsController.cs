using Microsoft.AspNetCore.Mvc;
using YourNamespace.Data;
using YourNamespace.Models;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintEventsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PrintEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostPrintEvent(PrintEvent printEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrintEvents.Add(printEvent);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
