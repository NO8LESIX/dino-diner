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

        public Menu menu = new Menu();
        public List<IMenuItem> Combos { get { return menu.AvaliableCombos; } }
        public List<IMenuItem> Drinks { get { return menu.AvaliableDrinks; } }
        public List<IMenuItem> Entrees { get { return menu.AvaliableEntrees; } }
        public List<IMenuItem> Sides { get { return menu.AvaliableSides; } }

        public void OnGet()
        {
            menu = new Menu();
        }
    }
}