using GenericRepositoryEntityFramework;
using Example.Core.Domain.Entities;
using Example.Core.Domain.Repositories;


namespace Example.Core.Persistence.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ExampleDbContext context) : base(context)
        {
            
        }

        public ExampleDbContext ExampleDbContext
        {
            get { return Context as ExampleDbContext; }
        }

        public override void Add(Order entity)
        {
            // We can override repository virtual methods in order to customize repository behavior, Template Method Pattern
            // Code here

            base.Add(entity);
        }
    }
}
