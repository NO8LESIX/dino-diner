using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;




namespace DinoDiner.Menu
{

    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Side Side { get; set; }

        private Size _size = Size.Small;

        public event PropertyChangedEventHandler PropertyChanged;

        public Size size
        {
            get { return _size; }
            set
            {
                _size = value;
                Drink.Size = Drink.Size;
                Side.Size = Side.Size;
            }
        }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price
        {
            get
            {
                return (Drink.Price + Entree.Price + Side.Price - 0.25);
            }
        }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return (Drink.Calories + Entree.Calories + Side.Calories);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        //public static CretaceousCombo GetCombo() { return new CretaceousCombo(); }
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Friceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Entree.ToString() + " Combo");
        }

        public string Description
        {
            get
            {
                return this.ToString();

            }
        }

        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                specials.AddRange(Entree.Special);
                specials.Add(Side.Description);
                specials.AddRange(Side.Special);
                specials.Add(Drink.Description);
                specials.AddRange(Drink.Special);
                return specials.ToArray();
            }
        }

    }
}
