using System;
using System.Threading;
using System.Threading.Tasks;
using Example.Core.Domain;
using Example.Core.Domain.Repositories;
using Example.Core.Persistence.Repositories;

namespace Example.Core.Persistence
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly ExampleDbContext _context;

        public IOrderRepository OrderRepository { get; private set; }


        public UnitOfWork(ExampleDbContext context)
        {
            _context = context;

            OrderRepository = new OrderRepository(_context);
        }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false);
        }


        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// No matter an exception has been raised or not, this method always will dispose the DbContext 
        /// </summary>
        /// <returns></returns>
        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }
    }
}
