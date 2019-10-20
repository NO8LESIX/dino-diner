using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Enum for the different flavours avaliable in the Soda drink.
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola, Orange, Vanilla, Chocolate, RootBeer, Cherry, Lime
    }
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public Sodasaurus()
        {
            size = Size.Small;
            Calories = 112;
            Price = 1.50;
        }
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients { get { return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" }; } }
        /// <summary>
        /// Gets and Set the natural flavour of the drink
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; } = SodasaurusFlavor.Cola;
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
                        Calories = 208;
                        Price = 2.50;
                        break;
                    case Size.Medium:
                        Calories = 156;
                        Price = 2.00;
                        break;
                    case Size.Small:
                        Calories = 112;
                        Price = 1.50;
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
            switch (Flavor)
            {
                case SodasaurusFlavor.Cherry:
                    sb.Append("Cherry ");
                    break;
                case SodasaurusFlavor.Chocolate:
                    sb.Append("Chocolate ");
                    break;
                case SodasaurusFlavor.Cola:
                    sb.Append("Cola ");
                    break;
                case SodasaurusFlavor.Lime:
                    sb.Append("Lime ");
                    break;
                case SodasaurusFlavor.Orange:
                    sb.Append("Orange ");
                    break;
                case SodasaurusFlavor.RootBeer:
                    sb.Append("RootBeer ");
                    break;
                case SodasaurusFlavor.Vanilla:
                    sb.Append("Vanilla ");
                    break;
                default:
                    break;
            }

            sb.Append("Sodasaurus");
            return sb.ToString();
        }


        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Gets any specital preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold Ice");
                return specials.ToArray();
            }
        }
    }
}
