using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Variable to manage the occurances of ingredients in a meal
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        /// <summary>
        /// Generates a list of the ingredients in a VelociWrap meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {"Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of a VelociWrap
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }
        /// <summary>
        /// Method used to remove dressing from the meal
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }
        /// <summary>
        /// Method used to remove lettuce from the meal
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }
        /// <summary>
        /// Method used to remove cheese from the meal
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
        public override string Description { get { return this.ToString(); } }
        public override string[] Special 
        {
            get
            {
                List<string> specials = new List<string>();
                if (!cheese) specials.Add("Hold Cheese");
                if (!dressing) specials.Add("Hold Dressing");
                if (!lettuce) specials.Add("Hold Lettuce");
                return specials.ToArray();
            }
        }
    }
}
