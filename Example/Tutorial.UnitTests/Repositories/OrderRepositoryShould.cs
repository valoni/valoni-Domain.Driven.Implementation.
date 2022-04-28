using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Example.Core.Persistence;
using Example.Core.Domain.Entities;
using Example.Core.Domain.ValueObjects;
using Example.Core.Persistence.Repositories;
using Example.Core.Domain.Enums;

namespace Example.UnitTests.Repositories
{
    public class OrderRepositoryShould
    {
        private DbContextOptionsBuilder<ExampleDbContext> _builder;

        private ExampleDbContext _dbContext;

        private OrderRepository _orderRepository;


        [OneTimeSetUp]
        public void Setup()
        {
            _builder = new DbContextOptionsBuilder<ExampleDbContext>()
                .UseInMemoryDatabase(databaseName: "Test_OrderRepository_Database");

            _dbContext = new ExampleDbContext(_builder.Options);

            _orderRepository = new OrderRepository(_dbContext);
        }


        [Test]
        public async Task Test_MethodAdd_TrackingNumberMustNotBeNull_Ok()
        {
            // arrange
            var order = new Order("KOSOVE", new OrderItem[]
                                    {
                                        new OrderItem (3, new Price(2000, MoneyUnit.Euro))
                                    });

            // act

            _orderRepository.Add(order);

            var actualOrder = await _orderRepository.GetByIdAsync(1);

            // assert
            Assert.IsNotNull(actualOrder);

            Assert.IsNotNull(actualOrder.TrackingNumber);
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            _dbContext.Dispose();
        }
    }
}
