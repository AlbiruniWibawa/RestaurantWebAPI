using Microsoft.EntityFrameworkCore;
using RestaurantWebAPI.Data;
using RestaurantWebAPI.Models;

namespace RestaurantWebAPI.Services
{
    public class FoodService : IFoodService
    {
        private readonly RestaurantContext _context;

        public async Task<IEnumerable<Food>> GetFoodList()
        {
            return await _context.Foods
                .ToListAsync();
        }

        public async Task<Food> GetFoodById(int id)
        {
            return await _context.Foods
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Food> CreateFood(Food food)
        {
            _context.Foods.Add(food);
            await _context.SaveChangesAsync();
            return food;
        }

        public async Task UpdateFood(Food food)
        {
            _context.Foods.Update(food);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFood(Food food)
        {
            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();
        }
    }
}
