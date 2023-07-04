using Parcial.Models;

namespace Parcial.ViewModels;

public class MenuDetailViewModel
{    
   public int Id {get;set;}

    public string Name {get;set;}
    public decimal Price {get;set;}
    public string Type {get;set;}
    
    public bool IsVegetarian {get;set;} = false;

    public int Calories {get;set;}

    public  List<Restaurant> Restaurants {get;set;} 
}