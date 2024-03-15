using Order_Service_Web_API.Models;

namespace Order_Service_Web_API.Services
{
    public interface IOrderService
    {
        //Get All Orders
        List<Order> GetOrdersList();
        //Get Order by OrderId
        Order GetOrderById(int OrderId);
        //Add or Update Order
        ResponseModel SaveOrder(Order OrderModel);
        //Delete Order
        ResponseModel DeleteOrder(int OrderId);
    }
}
