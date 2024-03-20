using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CafeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult ViewOrders()
        {
            var orders = _orderService.GetOrders();
            return Ok(orders);
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] Order order)
        {
            _orderService.PlaceOrder(order);
            return CreatedAtAction(nameof(ViewOrders), order);
        }

        [HttpDelete("{id}")]
        public IActionResult CancelOrder(int id)
        {
            var canceled = _orderService.CancelOrder(id);
            if (canceled)
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
