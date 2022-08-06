using Microsoft.EntityFrameworkCore;
using Ordering.Application.Contracts.Persistence;
using Ordering.Domian.Entities;
using Ordering.Infrastructure.Persistence.OrderContext;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext orderContext) : base(orderContext)
        {
        }

        public async Task<IEnumerable<Order>> GetOrderByUserName(string userName)
        {
            var orderList = await _orderContext.Orders!
                .Where(o => o.UserName == userName)
                .ToListAsync();
            return orderList;
        }
    }
}
