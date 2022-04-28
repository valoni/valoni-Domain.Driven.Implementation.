using System.Collections.Generic;

namespace ExampleWebAPI.Models.OrderModels
{
    public class OrderSaveRequestModel
    {
        /// <example>Prishtine Kosove</example>
        public string ShippingAdress { get; set; }

        public IEnumerable<OrderItemSaveRequestModel> OrderItemsDtoModel { get; set; }
    }
}
