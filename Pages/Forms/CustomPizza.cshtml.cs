using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Model;

namespace Pizza.Pages.Forms
{
    public class CustomPizza : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public int PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if(Pizza.TomatoSauce) PizzaPrice += 10;
            if(Pizza.Cheese) PizzaPrice += 20;
            if(Pizza.Mushromm) PizzaPrice += 20;
            if(Pizza.Pineapple) PizzaPrice += 30;
            if(Pizza.Ham) PizzaPrice += 20;
            if(Pizza.Beef) PizzaPrice += 30;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}