using DI_LifeCycle.Models;

namespace DI_LifeCycle.Data
{
    public class OrderRepository : IOrderRepository
    {
        public Order ObtainOrder()
        {
            return new Order();
        }
    }

    public interface IOrderRepository
    {
        Order ObtainOrder();
    }
}
