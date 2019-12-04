using System;
using System.Collections.Generic;
using System.Linq;
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
        /// 

        public List<IMenuItem> AvailableMenuItems 
        {
            get
            {   
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();

                // All available Entrees
                Brontowurst brontowurst = new Brontowurst();
                availableMenuItems.Add(brontowurst);
                DinoNuggets dino = new DinoNuggets();
                availableMenuItems.Add(dino);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                availableMenuItems.Add(pbj);
                PterodactylWings pterodactylWings = new PterodactylWings();
                availableMenuItems.Add(pterodactylWings);
                SteakosaurusBurger steakosaurusBurger = new SteakosaurusBurger();
                availableMenuItems.Add(steakosaurusBurger);
                TRexKingBurger rexKingBurger = new TRexKingBurger();
                availableMenuItems.Add(rexKingBurger);
                VelociWrap velociWrap = new VelociWrap();
                availableMenuItems.Add(velociWrap);


                //All available Sides
                Fryceritops fryceritops = new Fryceritops();
                availableMenuItems.Add(fryceritops);
                MeteorMacAndCheese meteorMacAndCheese = new MeteorMacAndCheese();
                availableMenuItems.Add(meteorMacAndCheese);
                MezzorellaSticks mezzorellaSticks = new MezzorellaSticks();
                availableMenuItems.Add(mezzorellaSticks);
                Triceritots triceritots = new Triceritots();
                availableMenuItems.Add(triceritots);

                //All available drinks
                JurassicJava jurassicJava = new JurassicJava();
                availableMenuItems.Add(jurassicJava);
                Sodasaurus sodasaurus = new Sodasaurus();
                availableMenuItems.Add(sodasaurus);
                Tyrannotea tyrannotea = new Tyrannotea();
                availableMenuItems.Add(tyrannotea);
                Water water = new Water();
                availableMenuItems.Add(water);

                return availableMenuItems;
            }
        }



        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// (AvailableEntrees)
        /// </summary>
        public List<Entree> AvailableEntrees 
        {
            get
            {
                List<Entree> availableEntrees = new List<Entree>();
                foreach (IMenuItem item in this.AvailableMenuItems)
                {
                    if (item is Entree)
                    {
                        availableEntrees.Add((Entree)item);
                    }
                }
                return availableEntrees;
            }
        }
        

        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// (AvailableEntrees), sides (AvailableSides), drinks (AvailableDrinks), 
        /// and combos (AvailableCombos).
        /// </summary>
        public List<Side> AvailableSides 
        {
            get
            {
                List<Side> availableSides = new List<Side>();
                foreach (IMenuItem item in this.AvailableMenuItems)
                {
                    if (item is Side)
                    {
                        availableSides.Add((Side)item);
                    }
                }
                return availableSides;
            }
        }

        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// (AvailableEntrees), sides (AvailableSides), drinks (AvailableDrinks), 
        /// and combos (AvailableCombos).
        /// </summary>
        public List<Drink> AvailableDrinks 
        {
            get
            {
                List<Drink> availableDrinks = new List<Drink>();
                foreach (IMenuItem item in this.AvailableMenuItems)
                {
                    if (item is Drink)
                    {
                        availableDrinks.Add((Drink)item);
                    }
                }
                return availableDrinks;
            }
        }

        /// <summary>
        /// implement a property with a getter to return all available entrees 
        /// combos (AvailableCombos).
        /// </summary>
        public List<CretaceousCombo> AvailableCombos 
        {
            get
            {
                List<CretaceousCombo> availableCombos = new List<CretaceousCombo>();
                foreach (IMenuItem item in this.AvailableMenuItems)
                {
                    if (item is Entree)
                    {
                        availableCombos.Add(new CretaceousCombo((Entree)item));
                    }
                }
                return availableCombos;
            }
        }


        /// <summary>
        /// All Available Ingredients
        /// </summary>
        public HashSet<string> AvailableIngredients
        {
            get
            {
                HashSet<string> ingredients = new HashSet<string>();
            
                foreach (IMenuItem item in AvailableMenuItems) 
                { 
                    foreach (string ingredient in item.Ingredients)
                    {
                        ingredients.Add(ingredient);
                    }
                }
                return ingredients;
            }
        } 





        /// <summary>
        /// should also override the ToString() method to display the full menu contents,
        /// separated by new line characters (\n).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = " ";
            foreach (IMenuItem item in AvailableMenuItems)
            {
                output += item + "\n";
            }
            return output;
        }
        
            

    } // End of Menu class
}
