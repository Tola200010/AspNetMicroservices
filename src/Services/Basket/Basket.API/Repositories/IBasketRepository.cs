using Basket.API.Entitires;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart?> GetBasket(string username);
        Task<ShoppingCart?> UpdateBasket(ShoppingCart basket);
        Task DeleteBasket(string username);
    }
}
