using Parcial.Models;

namespace Parcial.Services;

public interface IRestaurantService
{
    void Create(Restaurant obj);
    List<Restaurant> GetAll();

    void Update(Restaurant obj, int id);

    void Delete(Restaurant obj);

    Restaurant GetById(int id);
    void Update(Restaurant restaurant);
}