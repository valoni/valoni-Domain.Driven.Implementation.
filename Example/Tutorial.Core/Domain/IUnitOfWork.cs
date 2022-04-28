using System.Threading;
using System.Threading.Tasks;
using Example.Core.Domain.Repositories;

namespace Example.Core.Domain
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepository { get; }

        Task<int> CompleteAsync();

        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }
}
