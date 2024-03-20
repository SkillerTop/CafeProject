using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CafeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public CafeController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public IActionResult ViewMenu()
        {
            var menuItems = _menuService.GetMenuItems();
            return Ok(menuItems);
        }

        [HttpPost]
        public IActionResult AddMenuItem([FromBody] MenuItem menuItem)
        {
            _menuService.AddMenuItem(menuItem);
            return CreatedAtAction(nameof(ViewMenu), menuItem);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMenuItem(int id, [FromBody] MenuItem menuItem)
        {
            var updated = _menuService.UpdateMenuItem(id, menuItem);
            if (updated)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveMenuItem(int id)
        {
            var removed = _menuService.RemoveMenuItem(id);
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
