using Example.Core.Domain.ValueObjects;

namespace ExampleWebAPI.Models.OrderModels
{
    public class OrderItemSaveRequestModel
    {
        /// <example>1</example>
        public int? ProductId { get; set; }
   
        public PriceSaveRequestModel Price { get; set; }
    }
}
