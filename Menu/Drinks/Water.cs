using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    public class Water : Drink
    {
        /// <summary>
        /// Controls the size of he drink in this instance of tea
        /// </summary>
        protected Size size;
        public bool lemon = false;
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public Water()
        {
            size = Size.Small;
            Calories = 0;
            Price = 0.10;
        }
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
                        Calories = 0;
                        Price = 0.10;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Size.Medium:
                        Calories = 0;
                        Price = .10;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Size.Small:
                        Calories = 0;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        Price = 0.10;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return (lemon == false) ? new List<string>{"Water"} : new List<string> { "Water", "Lemon"};
            }
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
            sb.Append("Water");
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
