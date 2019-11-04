using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        /// <summary>
        /// leaves room for cream if true
        /// </summary>
        public bool roomForCream = false;
        /// <summary>
        /// Makes the drink decaf
        /// </summary>
        public bool decaf = false;
        /// <summary>
        /// Getter and setter for the decaffinated property
        /// </summary>
        public bool Decaf { get { return decaf; } set { decaf = value; } }
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public JurassicJava()
        {
            size = Size.Small;
            Calories = 2;
            Price = 0.59;
        }
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
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
                        Calories = 8;
                        Price = 1.49;
                        Ice = false;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Size.Medium:
                        Calories = 4;
                        Price = .99;
                        Ice = false;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Size.Small:
                        Calories = 2;
                        Price = 0.59;
                        Ice = false;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Makes room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            roomForCream = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Makes the drink decalf
        /// </summary>
        public void MakeDecaf()
        {
            decaf = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Adds Ice
        /// </summary>
        public void AddIce()
        {
            Ice = true;
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
            if (Decaf == true)
                sb.Append("Decaf ");
            sb.Append("Jurassic Java");
            return sb.ToString();
        }
        /// <summary>
        /// 
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
                if (Ice) specials.Add("Add Ice");
                if (roomForCream) specials.Add("Leave Room For Cream");
                return specials.ToArray();
            }
        }
        /// <summary>
        /// The Property Changed event handler; notifies of changes to the Price, Description, and Special Properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
