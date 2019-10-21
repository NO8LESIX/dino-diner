using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Stores the number of additional chicken nuggets added to the value meal
        /// </summary>
        private uint chickenNugget;
        /// <summary>
        /// Generates a list of the ingredients in a DinoNuggets meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                for (int i = 0; i < chickenNugget; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor that takes in no parameters and sets default Price and Calories
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 6 * 59;
        }
        /// <summary>
        /// Adds an additional nugget to the value meal and updates the Price and Calories
        /// </summary>
        public void AddNugget()
        {
            chickenNugget++;
            Price = 4.25 + (chickenNugget * 0.25);
            Calories = (6 * 59) + (chickenNugget * 59);
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Calories");
        }
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (chickenNugget > 0) specials.Add((chickenNugget).ToString() + " Extra Nuggets");
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
