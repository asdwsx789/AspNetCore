using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Model;

namespace Pizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=60, TomatoSauce=true, Cheese=true, FinalPrice=90},
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=60, TomatoSauce=true, Cheese=true, Ham=true, FinalPrice=110},
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=60, TomatoSauce=true, Cheese=true, Beef=true, FinalPrice=120},
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=60, TomatoSauce=true, Cheese=true, Pineapple=true, Ham=true, FinalPrice=130},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="Meat Feast", BasePrice=60, TomatoSauce=true, Cheese=true, Ham=true, FinalPrice=110},
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", TomatoSauce=true, BasePrice=60, Cheese=true, Mushromm=true, FinalPrice=110},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=60, TomatoSauce=true, Cheese=true, Ham=true, FinalPrice=110},
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=60, TomatoSauce=true, Cheese=true, FinalPrice=90},
            new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=60, TomatoSauce=true, Cheese=true, Mushromm=true, FinalPrice=110}
        }; 
        public void OnGet()
        {
           
        }
    } 
}