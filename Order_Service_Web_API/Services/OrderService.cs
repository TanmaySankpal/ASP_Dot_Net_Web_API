using Order_Service_Web_API.Models;

namespace Order_Service_Web_API.Services
{
    public class OrderService : IOrderService
    {
        private OrdContext _rdContext;
        public OrderService(OrdContext rdContext)
        {
            _rdContext=rdContext;
        }
        public List<Order> GetOrdersList()
        {
            List<Order> ordList;
            try
            {
                ordList = _rdContext.Set<Order>().ToList();
            }catch (Exception ex)
            {
                throw;
            }
            return ordList;
        }

        public Order GetOrderById(int OrderId)
        {
            Order Ord;
            try
            {
                Ord = _rdContext.Find<Order>(OrderId);
            }
            catch (Exception )
            {
                throw;
            }
            return Ord;
        }

        public ResponseModel SaveOrder(Order OrderModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Order _temp = GetOrderById(OrderModel.OrderID);
                if(_temp!=null)
                {
                    _temp.CustomerName = OrderModel.CustomerName;
                    _temp.Address = OrderModel.Address;
                    _temp.Currency = OrderModel.Currency;
                    _temp.Price = OrderModel.Price;
                    _temp.Quantity = OrderModel.Quantity;
                    _temp.ToatlPrice = OrderModel.ToatlPrice;
                    _temp.OrderDate = OrderModel.OrderDate;
                    _temp.OrderStatus = OrderModel.OrderStatus;
                    _temp.Notes = OrderModel.Notes;
                    _temp.PaymentMethod = OrderModel.PaymentMethod;
                    _temp.ShippingMethod = OrderModel.ShippingMethod;
                    model.Messsage_Detail = "Order Update Successfully";
                }
                else
                {
                    _rdContext.Add<Order>(OrderModel);
                    model.Messsage_Detail = "Order Inserted Successfully";
                }
                _rdContext.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage_Detail = "Error "+ex.Message;
            }
            return model;
        }
        public ResponseModel DeleteOrder(int OrderId)
        {
           ResponseModel model=new ResponseModel();
            try
            {
                Order _temp = GetOrderById(OrderId);
                if(_temp.OrderID!=null)
                {
                    _rdContext.Remove<Order>(_temp);
                    _rdContext.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage_Detail = "Employee Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage_Detail = "Employee Not Found";
                }
            }
            catch(Exception ex)
            {
                model.IsSuccess= false;
                model.Messsage_Detail = "Error " + ex.Message;
            }
            return model;
        }

    }
}
