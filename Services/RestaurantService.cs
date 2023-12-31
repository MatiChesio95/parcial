using Parcial.Models;
using Parcial.Data;
using Microsoft.EntityFrameworkCore;

namespace Parcial.Services;

public class RestaurantService : IRestaurantService
{
    private readonly MenuContext _context;

    public RestaurantService(MenuContext context)
    {
        _context = context;
    }

    public void Create(Restaurant obj)
    {
        _context.Add(obj);
        _context.SaveChanges();
    }

    public void Delete(Restaurant obj)
    {
        _context.Remove(obj);
        _context.SaveChanges();
    }

    public List<Restaurant> GetAll()
    {
        return _context.Restaurant.Include(r => r.Menus).ToList();
    }

    public Restaurant? GetById(int id)
    {
        var restaurant = _context.Restaurant
                .Include(r => r.Menus)
                .FirstOrDefault(m => m.Id == id);

        return restaurant;
    }

    public void Update(Restaurant obj)
    {
        _context.Update(obj);
        _context.SaveChanges();
    }

    public void Update(Restaurant obj, int id)
    {
        throw new NotImplementedException();
    }
}