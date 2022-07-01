using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaModel Pizza { get; set; }
        public int PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Pizza.Price = Pizza.BasePrice;

            //Extra cost for ingredients
            if (Pizza.TomatoSauce) PizzaPrice += 20;
            if (Pizza.Beef) PizzaPrice += 40;
            if (Pizza.Cheese) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 20;
            if (Pizza.Mushroom) PizzaPrice += 10;
            if (Pizza.Peperoni) PizzaPrice += 30;
            if (Pizza.Pineapple) PizzaPrice += 20;
            if (Pizza.Tuna) PizzaPrice += 40;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, Pizza.Price });
        }
    }
}
