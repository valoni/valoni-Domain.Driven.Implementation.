using Example.Core.Domain.ValueObjects;

namespace ExampleWebAPI.Models.OrderModels
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Price Price { get; set; }
    }
}
