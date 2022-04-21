using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza.Model;
using Pizza.Data;

namespace Pizza.Pages
{
    public class OrderModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        private readonly ApplicationDbContext _context;

        public OrderModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            var a = _context.PizzzaOrders.FromSqlRaw("SELECT * FROM dbo.PizzzaOrders").Take(2);
            PizzaOrders = a.ToList();
            //PizzaOrders = _context.PizzzaOrders.ToList();
        }
    }
}