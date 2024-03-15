using Microsoft.AspNetCore.Mvc;
using Order_Service_Web_API.Models;
using Order_Service_Web_API.Services;

namespace Order_Service_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        IOrderService _orderService;
        public OrderController(IOrderService service)
        {
            _orderService = service;
        }

        //Get All Orders
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetOrdersList() 
        {
            try
            {
                var Orders = _orderService.GetOrdersList();
                if (Orders == null)
                    return NotFound();
                return Ok(Orders);
            }
            catch (Exception ex) 
            {
                return BadRequest();
            }
        }

        //Get Order by OrderId
        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetOrderById(int id)
        {
            try
            {
                var Orders = _orderService.GetOrderById(id);
                if (Orders == null)
                    return NotFound();
                return Ok(Orders);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        //Add or Update Order
        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveOrder(Order orderModel)
        {
            try
            {
                var model = _orderService.SaveOrder(orderModel);
                return Ok(model);
            }catch(Exception ex) 
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteOrder(int id) 
        {
            try 
            {
                var model = _orderService.DeleteOrder(id);
                    return Ok(model);
            }catch(Exception e) 
            {
                return BadRequest();
            }
        }
    }
}
