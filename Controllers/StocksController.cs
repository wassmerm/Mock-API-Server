using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mock_API_Server.Data;
using Mock_API_Server.Models;

namespace Mock_API_Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StocksController : ControllerBase
    {
        private readonly DataContext context;
        public StocksController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStocks() {
          return await context.Stocks.ToListAsync();
        }

         [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStock(int id) {
          return await context.Stocks.FindAsync(id);
        }
    }
}