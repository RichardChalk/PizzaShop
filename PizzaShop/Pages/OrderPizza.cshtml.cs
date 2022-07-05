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
                Pineapple = true,
                Price = 140,
            },
            new PizzaModel()
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 80,
                TomatoSauce = true,
                Cheese = true,
                Tuna = true,
                Price = 130,
            },
            new PizzaModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Peperoni",
                BasePrice = 80,
                TomatoSauce = true,
                Cheese = true,
                Peperoni = true,
                Price = 140,
            },
            new PizzaModel()
            {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice = 80,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                Price = 140,
            },
            new PizzaModel()
            {
                ImageTitle = "Arnold",
                PizzaName = "Arnold Special",
                BasePrice = 80,
                TomatoSauce = true,
                Cheese = true,
                Bullets = true,
                Price = 180,
            },


        };
        public void OnGet()
        {
        }
    }
}
