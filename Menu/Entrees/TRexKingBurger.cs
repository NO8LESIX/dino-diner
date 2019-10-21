using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : SteakosaurusBurger
    {
        /// <summary>
        /// Variable to manage the occurance of mayo in a meal
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// Generates a list of the ingredients in a TRexKingBurger meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                    { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (getBun) ingredients.Add("Whole Wheat Bun");
                if (getPickle) ingredients.Add("Pickle");
                if (getKetchup) ingredients.Add("Ketchup");
                if (getMustard) ingredients.Add("Mustard");
                if (getLettuce) ingredients.Add("Lettuce");
                if (getTomato) ingredients.Add("Tomato");
                if (getOnion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of a TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }
        /// <summary>
        /// Method used to remove mayo from the meal
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
        public override string Description { get { return this.ToString(); } }
        public override string[] Special {
            get {
                List<string> specials = new List<string>();
                if (!getBun) specials.Add("Hold Whole Wheat Bun");
                if (!mayo) specials.Add("Hold Mayo");
                if (!getKetchup) specials.Add("Hold Ketchup");
                if (!getLettuce) specials.Add("Hold Lettuce");
                if (!getMustard) specials.Add("Hold Mustard");
                if (!getOnion) specials.Add("Hold Onion");
                if (!getPickle) specials.Add("Hold Pickle");
                if (!getTomato) specials.Add("Hold Tomato");
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
