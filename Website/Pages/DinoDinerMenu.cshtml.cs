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
        public bool clear { get; set; } = false;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> category { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        public HashSet<string> ingredients = menu.PossibleIngredients;

        private IEnumerable<IMenuItem> combos = menu.AvaliableCombos;
        public IEnumerable<IMenuItem> Combos { get { return combos; } set { combos = value; } }
        public IEnumerable<IMenuItem> drinks = menu.AvaliableDrinks;
        public IEnumerable<IMenuItem> Drinks { get { return drinks; } set { drinks = value; } }
        public IEnumerable<IMenuItem> entrees = menu.AvaliableEntrees;
        public IEnumerable<IMenuItem> Entrees { get { return entrees; } set { entrees = value; } }
        public IEnumerable<IMenuItem> sides = menu.AvaliableSides;
        public IEnumerable<IMenuItem> Sides { get { return sides; } set { sides = value; } }


        public void OnGet()
        {
        }

        public void OnPost()
        {
            menu = new Menu();
            if (clear)
            {
                ResetFilters();
                clear = false;
            }


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

        public static IEnumerable<IMenuItem> Search(IEnumerable<IMenuItem> menu, string term)
        {

            IEnumerable<IMenuItem> results = new List<IMenuItem>();

            results = menu.Where(item => item.GetType().Name.Contains(term) || item.ToString().Contains(term) || item.Ingredients.Contains(term));

            /*
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
            }*/

            return results;
        }

        public static IEnumerable<IMenuItem> FilterByMaxPrice(IEnumerable<IMenuItem> menu, float maxPrice)
        {
            IEnumerable<IMenuItem> results = menu.Where(item => item.Price <= maxPrice);
            /*
            foreach (IMenuItem item in menu)
            {
                if (item.Price <= maxPrice)
                {
                    results.Add(item);
                }
            }*/

            return results;
        }

        public static IEnumerable<IMenuItem> FilterIngredients(IEnumerable<IMenuItem> menu, List<string> term)
        {
            IEnumerable<IMenuItem> results = menu.Where(item =>
            {
                foreach (string str in term)
                {
                    if (item.Ingredients.Contains(str))
                    {
                        return false;
                    }
                }
                return true;
            }

            );
            /*
            foreach (IMenuItem item in menu)
            {
                foreach (string str in term)
                {
                    if (item.Ingredients.Contains(str) == false)
                    {
                        results.Add(item);
                    }
                }
            }*/

            return results;
        }

        public static IEnumerable<IMenuItem> FilterByMinPrice(IEnumerable<IMenuItem> menu, float minPrice)
        {
            IEnumerable<IMenuItem> results = menu.Where(item => item.Price >= minPrice);
            /*
            foreach (IMenuItem item in menu)
            {
                if (item.Price >= minPrice)
                {
                    results.Add(item);
                }
            }*/

            return results;
        }

        public void ResetFilters()
        {
            search = "";
            category = new List<string>();
            minimumPrice = (float)0.00;
            maximumPrice = (float)0.00;
            excludedIngredients = new List<string>();
            Combos = menu.AvaliableCombos;
            Drinks = menu.AvaliableDrinks;
            Entrees = menu.AvaliableEntrees;
            Sides = menu.AvaliableSides;

        }
    }
}