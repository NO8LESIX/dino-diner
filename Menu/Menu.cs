using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvaliablemenuItems
        {
            get
            {
                List<IMenuItem> mi = new List<IMenuItem>();
                mi.Add(new JurassicJava());
                mi.Add(new Sodasaurus());
                mi.Add(new Tyrannotea());
                mi.Add(new Water());

                mi.Add(new Brontowurst());
                mi.Add(new DinoNuggets());
                mi.Add(new PrehistoricPBJ());
                mi.Add(new PterodactylWings());
                mi.Add(new SteakosaurusBurger());
                mi.Add(new TRexKingBurger());
                mi.Add(new VelociWrap());

                mi.Add(new Fryceritops());
                mi.Add(new MeteorMacAndCheese());
                mi.Add(new MezzorellaSticks());
                mi.Add(new Triceritots());

                return mi;
            }

        }
        public List<IMenuItem> AvaliableEntrees
        {
            get
            {
                List<IMenuItem> mi = new List<IMenuItem>();

                mi.Add(new Brontowurst());
                mi.Add(new DinoNuggets());
                mi.Add(new PrehistoricPBJ());
                mi.Add(new PterodactylWings());
                mi.Add(new SteakosaurusBurger());
                mi.Add(new TRexKingBurger());
                mi.Add(new VelociWrap());

                return mi;
            }

        }

        public List<IMenuItem> AvaliableSides
        {
            get
            {
                List<IMenuItem> mi = new List<IMenuItem>();

                mi.Add(new Fryceritops());
                mi.Add(new MeteorMacAndCheese());
                mi.Add(new MezzorellaSticks());
                mi.Add(new Triceritots());

                return mi;
            }

        }
        public List<IMenuItem> AvaliableDrinks
        {
            get
            {
                List<IMenuItem> mi = new List<IMenuItem>();
                mi.Add(new JurassicJava());
                mi.Add(new Sodasaurus());
                mi.Add(new Tyrannotea());
                mi.Add(new Water());

                return mi;
            }

        }
        public List<IMenuItem> AvaliableCombos
        {
            get
            {
                List<IMenuItem> mi = new List<IMenuItem>();
                mi.Add(new CretaceousCombo(new Brontowurst()));
                mi.Add(new CretaceousCombo(new DinoNuggets()));
                mi.Add(new CretaceousCombo(new PrehistoricPBJ()));
                mi.Add(new CretaceousCombo(new PterodactylWings()));
                mi.Add(new CretaceousCombo(new SteakosaurusBurger()));
                mi.Add(new CretaceousCombo(new TRexKingBurger()));
                mi.Add(new CretaceousCombo(new VelociWrap()));
                return mi;
            }
        }
        public override string ToString()
        {
            List<IMenuItem> mi = new List<IMenuItem>();
            mi.Add(new JurassicJava());
            mi.Add(new Sodasaurus());
            mi.Add(new Tyrannotea());
            mi.Add(new Water());

            mi.Add(new Brontowurst());
            mi.Add(new DinoNuggets());
            mi.Add(new PrehistoricPBJ());
            mi.Add(new PterodactylWings());
            mi.Add(new SteakosaurusBurger());
            mi.Add(new TRexKingBurger());
            mi.Add(new VelociWrap());

            mi.Add(new Fryceritops());
            mi.Add(new MeteorMacAndCheese());
            mi.Add(new MezzorellaSticks());
            mi.Add(new Triceritots());

            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem item in mi)
                sb.Append(item.ToString() + "\n");

            return sb.ToString(); 
        }


    }//end of class
}
