﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzerai.Models;

namespace RazorPizzerai.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void onGet()
        {

        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Mashroom) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout",new {Pizza.PizzaName,PizzaPrice });
        }
    }
}




