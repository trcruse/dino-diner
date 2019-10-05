using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {

        /// <summary>
        /// property with a getter for AvailableMenuItems (List) which 
        /// should return a list containing one instance of every menu item 
        /// currently offered by DinoDiner
        /// </summary>
        public List<IMenuItem> AvailableMenuItems { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap(),
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water(),
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots()

        };



        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// (AvailableEntrees)
        /// </summary>
        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };

        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// (AvailableEntrees), sides (AvailableSides), drinks (AvailableDrinks), 
        /// and combos (AvailableCombos).
        /// </summary>
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots()
        };

        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// (AvailableEntrees), sides (AvailableSides), drinks (AvailableDrinks), 
        /// and combos (AvailableCombos).
        /// </summary>
        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water()
        };

        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// combos (AvailableCombos).
        /// </summary>
        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
            new CretaceousCombo(new Brontowurst()),
             new CretaceousCombo(new DinoNuggets()),
             new CretaceousCombo(new PrehistoricPBJ()),
             new CretaceousCombo(new PterodactylWings()),
             new CretaceousCombo(new SteakosaurusBurger()),
             new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };


        /// <summary>
        /// should also override the ToString() method to display the full menu contents,
        /// separated by new line characters (\n).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = " ";

            foreach (IMenuItem i in AvailableMenuItems)
            {
                output += i.ToString();
                output += "\n";
            }

            return output;
        }
        
            

    } // End 
}
