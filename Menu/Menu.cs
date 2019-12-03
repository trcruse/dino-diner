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

        //public List<IMenuItem> AvailableMenuItems
        //{
        //    get
        //    {
        //        List<IMenuItem> menuItems = new List<IMenuItem>();
        //        menuItems.AddRange(AvailableCombos);
        //        menuItems.AddRange(AvailableEntrees);
        //        menuItems.AddRange(AvailableSides);
        //        menuItems.AddRange(AvailableDrinks);
        //        return menuItems;
        //    }
        //}

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
        public List<Entree> AvailableEntrees { get; } = new List<Entree>()
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
        public List<Side> AvailableSides { get; } = new List<Side>()
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
        public List<Drink> AvailableDrinks { get; } = new List<Drink>()
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
        public List<CretaceousCombo> AvailableCombos { get; } = new List<CretaceousCombo>()
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
        /// 
        /// </summary>
        public List<string> IngredientsNotDuplicated
        {
            get
            {
                HashSet<string> ingredientsNotDuplicated = new HashSet<string>();
            
                foreach (IMenuItem item in AvailableMenuItems) 
                { 
                    ingredientsNotDuplicated.UnionWith(item.Ingredients);
                }
                List<string> returning = ingredientsNotDuplicated.OrderBy(ingredient => ingredient).ToList();
                return returning;
            }
        } 


        public static List<T> Search<T>(List<T> menuItems, string searchT) where T: IMenuItem
        {
            List<T> results = new List<T>();
            foreach(T item in menuItems)
            {
                if (item.Description.ToLower().Contains(searchT.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }


        public static List<T> FilterByMinPrice<T>(List<T> menuItems, float min) where T : IMenuItem
        {
            List<T> results = new List<T>();
            foreach(T item in menuItems)
            {
                if (item.Price >= min)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static List<T> FilterByMaxPrice<T>(List<T> menuItems, float max) where T : IMenuItem
        {
            List<T> results = new List<T>();
            foreach(T item in menuItems)
            {
                if(item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }


        public static List<T> FilterByExcludedIngriedents<T>(List<T> menuItems, List<string> excludedIngredients)
            where T : IMenuItem
        {
            List<T> results = new List<T>();
            foreach(T item in menuItems)
            {
                bool passesFilter = true;
                foreach(string ingredient in excludedIngredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                    {
                        passesFilter = false;
                        break;
                    }
                }
                if (passesFilter)
                {
                    results.Add(item);
                }
            }
            return results;
        }



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
        
            

    } // End of Menu class
}
