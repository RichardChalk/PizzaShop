using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages
{
    public class OrderPizzaModel : PageModel
    {
        public List<PizzaModel> fakePizzaDB = new List<PizzaModel>()
        {
            new PizzaModel()
            {
                ImageTitle = "Margerita",
                PizzaName = "Margarita",
                BasePrice = 80,
                TomatoSauce = true,
                Cheese = true,
                Price = 120,
            },
            new PizzaModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                BasePrice = 80,
                TomatoSauce = true,
                Cheese = true,
                Price = 120,
            },
            new PizzaModel()
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 80,
                TomatoSauce = true,
                Cheese = true,
                Price = 120,
            },

        };
        public void OnGet()
        {
        }
    }
}
