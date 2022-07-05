using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaModel Pizza { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Pizza.Price = Pizza.BasePrice;

            //Extra cost for ingredients
            if (Pizza.TomatoSauce) Pizza.Price += 20;
            if (Pizza.Beef) Pizza.Price += 40;
            if (Pizza.Cheese) Pizza.Price += 10;
            if (Pizza.Ham) Pizza.Price += 20;
            if (Pizza.Bullets) Pizza.Price += 60;
            if (Pizza.Mushroom) Pizza.Price += 10;
            if (Pizza.Peperoni) Pizza.Price += 30;
            if (Pizza.Pineapple) Pizza.Price += 20;
            if (Pizza.Tuna) Pizza.Price += 40;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, Pizza.Price });
        }
    }
}
