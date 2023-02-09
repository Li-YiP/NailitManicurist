using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NailitManicurist.Models;

namespace NailIt.Controllers.YiPControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PCodeTableController : ControllerBase
    {
        private readonly NailitDBContext Context;
        public PCodeTableController(NailitDBContext PContext)
        {
            Context = PContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CodeTable>>> GetCCodeTable()
        {
            var Ccode = Context.CodeTables.Where(x => x.CodeUseIn == "C");
            return await Ccode.ToListAsync();
        }
    }
}
