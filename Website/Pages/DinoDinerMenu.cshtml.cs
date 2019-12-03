using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;


namespace Website.Pages
{
    public class DinoDinerMenuModel : PageModel
    {

        public static Menu menu = new Menu();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> category { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public string order { get; set; }

        public HashSet<string> ingredients = menu.PossibleIngredients;

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        private List<IMenuItem> combos = menu.AvaliableCombos;
        public List<IMenuItem> Combos { get { return combos; } set { combos = value; } }
        public List<IMenuItem> drinks = menu.AvaliableDrinks;
        public List<IMenuItem> Drinks { get { return drinks; } set { drinks = value; } }
        public List<IMenuItem> entrees = menu.AvaliableEntrees;
        public List<IMenuItem> Entrees { get { return entrees; } set { entrees = value; } }
        public List<IMenuItem> sides = menu.AvaliableSides;
        public List<IMenuItem> Sides { get { return sides; } set { sides = value; } }


        public void OnGet()
        {
        }

        public void OnPost()
        {
            menu = new Menu();

            if (search != null)
            {
                Combos = Search(Combos, search);
                Drinks = Search(Drinks, search);
                Entrees = Search(Entrees, search);
                Sides = Search(Sides, search);
            }

            if (category.Count != 0)
            {
                if (category.Contains("combo"))
                {
                    Combos = menu.AvaliableCombos;
                }
                else
                {
                    Combos = new List<IMenuItem>();
                }
                if (category.Contains("side"))
                {
                    Sides = menu.AvaliableSides;
                }
                else
                {
                    Sides = new List<IMenuItem>();
                }
                if (category.Contains("drink"))
                {
                    Drinks = menu.AvaliableDrinks;
                }
                else
                {
                    Drinks = new List<IMenuItem>();
                }
                if (category.Contains("entree"))
                {
                    Entrees = menu.AvaliableEntrees;
                }
                else
                {
                    Entrees = new List<IMenuItem>();
                }
            }


            if (minimumPrice != null)
            {
                Combos = FilterByMinPrice(Combos, (float)minimumPrice);
                Entrees = FilterByMinPrice(Entrees, (float)minimumPrice);
                Sides = FilterByMinPrice(Sides, (float)minimumPrice);
                Drinks = FilterByMinPrice(Drinks, (float)minimumPrice);
            }

            if (maximumPrice != null)
            {
                Combos = FilterByMaxPrice(Combos, (float)maximumPrice);
                Entrees = FilterByMaxPrice(Entrees, (float)maximumPrice);
                Sides = FilterByMaxPrice(Sides, (float)maximumPrice);
                Drinks = FilterByMaxPrice(Drinks, (float)maximumPrice);
            }

            if (excludedIngredients.Count != 0)
            {
                Combos = FilterIngredients(Combos, excludedIngredients);
                Entrees = FilterIngredients(Entrees, excludedIngredients);
                Sides = FilterIngredients(Sides, excludedIngredients);
                Drinks = FilterIngredients(Drinks, excludedIngredients);
            }


        }

        public static List<IMenuItem> Search(List<IMenuItem> menu, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menu)
            {
                if (item.GetType().Name.Contains(term) || item.ToString().Contains(term))
                {
                    results.Add(item);
                }
                if (item.Ingredients.Contains(term))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menu, float maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menu)
            {
                if (item.Price <= maxPrice)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static List<IMenuItem> FilterIngredients(List<IMenuItem> menu, List<string> term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menu)
            {
                foreach (string str in term)
                {
                    if (item.Ingredients.Contains(str) == false)
                    {
                        results.Add(item);
                    }
                }
            }

            return results;
        }

        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> menu, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menu)
            {
                if (item.Price >= minPrice)
                {
                    results.Add(item);
                }
            }

            return results;
        }


    }
}