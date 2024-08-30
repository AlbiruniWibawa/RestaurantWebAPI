using RestaurantWebAPI.Models;

namespace RestaurantWebAPI.Services
{
    public interface IFoodService
    {
        Task<IEnumerable<Food>> GetFoodList();
        Task<Food> GetFoodById(int id);
        Task<Food> CreateFood(Food food);
        Task UpdateFood(Food food);
        Task DeleteFood(Food food);
    }
}
