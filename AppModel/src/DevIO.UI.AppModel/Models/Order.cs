namespace DevIO.UI.AppModel.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
        }
    }
}
