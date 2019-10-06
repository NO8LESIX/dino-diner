using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    public class Water : Drink
    {
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public Water()
        {
            size = Size.Small;
            Calories = 0;
            Price = 0.10;
        }
        public bool _lemon = false;
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
                        Calories = 0;
                        Price = 0.10;
                        break;
                    case Size.Medium:
                        Calories = 0;
                        Price = .10;
                        break;
                    case Size.Small:
                        Calories = 0;
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
                return (_lemon == false) ? new List<string>{"Water"} : new List<string> { "Water", "Lemon"};
            }
        }
        /// <summary>
        /// Method to add lemon to the drink
        /// </summary>
        public void AddLemon() => _lemon = true;
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
    }
}
