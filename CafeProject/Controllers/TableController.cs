using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CafeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet]
        public IActionResult ViewTables()
        {
            var tables = _tableService.GetTables();
            return Ok(tables);
        }

        [HttpPost]
        public IActionResult AddTable([FromBody] Table table)
        {
            _tableService.AddTable(table);
            return CreatedAtAction(nameof(ViewTables), table);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveTable(int id)
        {
            var removed = _tableService.RemoveTable(id);
            if (removed)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
