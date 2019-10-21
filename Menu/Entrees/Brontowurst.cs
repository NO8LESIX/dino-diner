using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Private variables used to determine the ingredients to add into the meal
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        /// <summary>
        /// Generates a list of the ingredients in a Brontowurst meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of Brontowurst
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }
        /// <summary>
        /// Method used to remove bun in the meal
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove peppers in the meal
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove onion from the meal
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "Brontowurst";
        }

        public override string Description { get { return this.ToString(); } }
        public override string[] Special 
        {
           get
            {
                List<string> specials = new List<string>();
                if (!bun) specials.Add("Hold Whole Wheat Bun");
                if (!peppers) specials.Add("Hold Peppers");
                if (!onions) specials.Add("Hold Onion");
                return specials.ToArray();
            } 
        }
        /// <summary>
        /// The Property Changed event handler; notifies of changes to the Price, Description, and Special Properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
