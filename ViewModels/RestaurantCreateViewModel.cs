using Parcial.Models;

namespace Parcial.ViewModels;

public class RestaurantCreateViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }

    public List<int> MenuIds { get; set; }
}