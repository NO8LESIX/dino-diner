﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Accessor used to control buns in the meal
        /// </summary>
        public bool getBun { get; set; } = true;
        /// <summary>
        /// Accessor used to control pickles in the meal
        /// </summary>
        public bool getPickle { get; set; } = true;
        /// <summary>
        /// Accessor used to control ketchup in the meal
        /// </summary>
        public bool getKetchup { get; set; } = true;
        /// <summary>
        /// Accessor used to control mustard in the meal
        /// </summary>
        public bool getMustard { get; set; } = true;
        /// <summary>
        /// Accessor used to control lettuce in the meal
        /// </summary>
        public bool getLettuce { get; set; } = true;
        /// <summary>
        /// Accessor used to control tomato in the meal
        /// </summary>
        public bool getTomato { get; set; } = true;
        /// <summary>
        /// Accessor used to control onion in the meal
        /// </summary>
        public bool getOnion { get; set; } = true;
        /// <summary>
        /// Generates a list of the ingredients in a SteakosaurusBurger meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (getBun) ingredients.Add("Whole Wheat Bun");
                if (getPickle) ingredients.Add("Pickle");
                if (getKetchup) ingredients.Add("Ketchup");
                if (getMustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of a SteakosaurusBurger
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }
        /// <summary>
        /// Method used to remove a bun from the meal
        /// </summary>
        public void HoldBun()
        {
            getBun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove pickles from the meal
        /// </summary>
        public void HoldPickle()
        {
            getPickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove ketchup from the meal
        /// </summary>
        public void HoldKetchup()
        {
            getKetchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove mustard from the meal
        /// </summary>
        public void HoldMustard()
        {
            getMustard = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove lettuce from the meal
        /// </summary>
        public void HoldLettuce()
        {
            getLettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove onions from the meal
        /// </summary>
        public void HoldOnion()
        {
            getOnion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove tomatoes from the meal
        /// </summary>
        public void HoldTomato()
        {
            getTomato = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!getBun) specials.Add("Hold Whole Wheat Bun");
                if (!getKetchup) specials.Add("Hold Ketchup");
                if (!getMustard) specials.Add("Hold Mustard");
                if (!getPickle) specials.Add("Hold Pickle");
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
