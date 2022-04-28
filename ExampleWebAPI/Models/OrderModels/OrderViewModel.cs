using System;
using System.Collections.Generic;

namespace ExampleWebAPI.Models.OrderModels
{
    /// <summary>
    /// OrderViewModel
    /// </summary>
    public class OrderViewModel
    { /// <summary>
      /// Id
      /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// TrackingNumber
        /// </summary>
        public Guid? TrackingNumber { get; set; }
        /// <summary>
        /// ShippingAdress
        /// </summary>
        public string ShippingAdress { get; set; }
        /// <summary>
        /// OrderDate
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// OrderItems 
        /// </summary>
        public IEnumerable<OrderItemViewModel> OrderItems { get; set; }
    }
}
