using AutoMapper;
using Example.Core.Domain.Entities;
using Example.Core.Domain.ValueObjects;
using ExampleWebAPI.Models.OrderModels;
using System.Collections.Generic;

namespace ExampleWebAPI.Models.DtoMappingConfigs
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderViewModel>();

            CreateMap<OrderSaveRequestModel, Order>()
            .ConstructUsing((src, res) =>
            {
                return new Order(src.ShippingAdress, orderItems: res.Mapper.Map<IEnumerable<OrderItem>>(src.OrderItemsDtoModel)
                );
            });


            

            CreateMap<OrderItem, OrderItemViewModel>();

            CreateMap<OrderItemSaveRequestModel, OrderItem>();

            CreateMap<PriceSaveRequestModel, Price>().ConvertUsing(x => new Price(x.Amount.Value, x.Unit.Value));
        }
    }
}
