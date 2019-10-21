using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Generates a list of the ingredients in a PterodactylWings meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of PterodactylWings
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
        public override string Description { get { return this.ToString(); } }
        public override string[] Special { get; }
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
