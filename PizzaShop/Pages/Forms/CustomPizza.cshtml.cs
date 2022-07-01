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

        //public IActionResult OnPost()
        //{

        //}
    }
}
