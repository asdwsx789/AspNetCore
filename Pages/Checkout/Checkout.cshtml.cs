using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza.Model;
using Pizza.Data;

namespace Pizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class Checkout : PageModel
    {
        public string PizzaName { get; set; }
        public int PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;

        public Checkout(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}