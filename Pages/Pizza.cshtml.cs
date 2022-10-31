using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlayground.Models;

namespace PizzaPlayground.Pages;

public class Pizza : PageModel
{
    public List<PizzaModel> fakePizzaDB = new List<PizzaModel>()
    {
        new PizzaModel()
        {
            ImageTitle = "Margerita", 
            PizzaName = "Margerita",
            BasePrice = 2,
            TomatoSauce = true,
            Cheese = true,
            FinalPrice = 4
        },
        new PizzaModel()
        {
            ImageTitle = "Bolognese", 
            PizzaName = "Bolognese",
            BasePrice = 2,
            TomatoSauce = true,
            Cheese = true,
            FinalPrice = 4
        },

        new PizzaModel()
        {
            ImageTitle = "Carbonara", 
            PizzaName = "Carbonara",
            BasePrice = 2,
            TomatoSauce = true,
            Cheese = true,
            FinalPrice = 4
        },
        new PizzaModel()
        {
            ImageTitle = "MeatFeast", 
            PizzaName = "MeatFeast",
            BasePrice = 2,
            TomatoSauce = true,
            Cheese = true,
            Pineapple = true,
            FinalPrice = 4
        },

        new PizzaModel()
        {
            ImageTitle = "Hawaiian", 
            PizzaName = "Hawaiian",
            BasePrice = 2,
            TomatoSauce = true,
            Cheese = true,
            Pineapple = true,
            FinalPrice = 4
        },

        new PizzaModel()
        {
            ImageTitle = "Pepperoni", 
            PizzaName = "Pepperoni",
            BasePrice = 2,
            TomatoSauce = true,
            Cheese = true,
            Pineapple = true,
            FinalPrice = 4
        },

    };

    public void OnGet()
    {
    }
}
