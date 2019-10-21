using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Variable to manage the occurance of peanut butter in a meal
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Variable to manage the occurance of jelly in a meal
        /// </summary>
        private bool jelly = true;
        /// <summary>
        /// Generates a list of the ingredients in a PrehistoricPBJ meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of PrehistoricPBJ 
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }
        /// <summary>
        /// The Property Changed event handler; notifies of changes to the Price, Description, and Special Properties.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Method used to remove peanut butter from the meal
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method used to remove jelly from the meal
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Returns this item's name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
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
                if (!peanutButter) specials.Add("Hold Peanut Butter");
                if (!jelly) specials.Add("Hold Jelly");
                return specials.ToArray();
            }
        }

    }
}
