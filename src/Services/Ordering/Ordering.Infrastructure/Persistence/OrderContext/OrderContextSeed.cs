using Microsoft.Extensions.Logging;
using Ordering.Domian.Entities;

namespace Ordering.Infrastructure.Persistence.OrderContext
{
    public class OrderContextSeed
    {
        private readonly ILogger<OrderContextSeed> _logger;
        private readonly OrderContext _orderContext;

        public OrderContextSeed(ILogger<OrderContextSeed> logger, OrderContext orderContext)
        {
            _logger = logger;
            _orderContext = orderContext;
        }

        public async Task SeedAsync()
        {
            if (!_orderContext.Orders!.Any())
            {
                _orderContext.Orders!.AddRange(GetPreconfiguredOrders());
                await _orderContext.SaveChangesAsync();
                _logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }
        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order() {UserName = "swn", FirstName = "Mehmet", LastName = "Ozkaya", EmailAddress = "ezozkme@gmail.com", AddressLine = "Bahcelievler", Country = "Turkey", TotalPrice = 350 }
            };
        }
    }
}
