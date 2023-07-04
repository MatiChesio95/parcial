using Parcial.Models;

namespace Parcial.ViewModels;

public class MenuViewModel
{
    public List<Menu> Menus {get;set;} = new List<Menu>();
    
    public string? NameFilter {get;set;}
}