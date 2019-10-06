using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
        /// <summary>
        /// Creates a new instance of Triceritots as a small side
        /// </summary>
        public Triceritots()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// Generates a list of the ingredients in a Triceritots
        /// </summary>
        public override List<string> Ingredients { get { return new List<string>() { "Potato", "Salt", "Breading","Vegetable Oil" }; } }
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
                        Calories = 590;
                        Price = 1.95;
                        break;
                    case Size.Medium:
                        Calories = 410;
                        Price = 1.45;
                        break;
                    case Size.Small:
                        Calories = 352;
                        Price = 0.99;
                        break;
                }
            }
            get { return size; }
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
            sb.Append("Triceritots");
            return sb.ToString();
        }

    }
}
