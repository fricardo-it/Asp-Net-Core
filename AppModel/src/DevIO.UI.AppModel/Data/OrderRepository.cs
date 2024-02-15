using DevIO.UI.AppModel.Models;

namespace DevIO.UI.AppModel.Data
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
