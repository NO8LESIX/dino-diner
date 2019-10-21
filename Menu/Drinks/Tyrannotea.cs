using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public Tyrannotea()
        {
            size = Size.Small;
            Calories = 8;
            Price = 0.99;
        }
        /// <summary>
        /// Controls if there is lemon in the drink
        /// </summary>
        public bool lemon = false;
        /// <summary>
        /// Controls if there are any added sweeteners
        /// </summary>
        public bool sweetened = false;
        public bool Sweet { get { return sweetened; } set { sweetened = value; } }
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (lemon == true)
                    ingredients.Add("Lemon");
                if (sweetened == true)
                    ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// Controls the size of he drink in this instance of tea
        /// </summary>
        protected Size size;
        /// <summary>
        /// Sets the size of the selected side and updates the Calories and Price accordingly
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Calories = 32;
                        Price = 1.99;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Size.Medium:
                        Calories = 16;
                        Price = 1.49;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Size.Small:
                        Calories = 8;
                        Price = 0.99;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Method to add lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to add sugar to the drink
        /// </summary>
        public void AddSugar()
        {
            sweetened = true;
            switch (size)
            {
                case Size.Large:
                    Calories = 64;
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Ingredients");
                    NotifyOfPropertyChange("Calories");
                    break;
                case Size.Medium:
                    Calories = 32;
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Ingredients");
                    NotifyOfPropertyChange("Calories");
                    break;
                case Size.Small:
                    Calories = 16;
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Ingredients");
                    NotifyOfPropertyChange("Calories");
                    break;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            switch (size)
            {
                case Size.Large:
                    sb.Append("Large ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Small:
                    sb.Append("Small ");
                    break;
                default:
                    break;
            }

            if (Sweet == true)
                sb.Append("Sweet ");
            sb.Append("Tyrannotea");
            return sb.ToString();
        }

        /// <summary>
        /// Gets and sets the description of the ingredients
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Gets any specital preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (lemon) specials.Add("Lemon");
                if (!Ice) specials.Add("Hold Ice");
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
