using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;


namespace Website.Pages
{
    public class MenuModel : PageModel
    {

        /// <summary>
        /// Instance calling Menu
        /// </summary>
        public Menu Menu
        {
            get
            {
                return new Menu();
            }
        }

        /// <summary>
        /// List of Available Combos
        /// </summary>
        public IEnumerable<CretaceousCombo> AvailableCombos { get; set; }

        /// <summary>
        /// List of Available Entrees
        /// </summary>
        //public List<Entree> AvailableEntrees { get; set; } 
        public IEnumerable<Entree> AvailableEntrees { get; set; }

        /// <summary>
        /// List of Available Sides
        /// </summary>
        public IEnumerable<Side> AvailableSides { get; set; }

        /// <summary>
        /// List of Available drinks
        /// </summary>
        public IEnumerable<Drink> AvailableDrinks { get; set; }

        /// <summary>
        ///search functionality to using Linq with IEnumberable.Where method
        /// </summary>
        [BindProperty]
        public string search { get; set; } 

        /// <summary>
        /// Binding Property for menuCategory
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// Binding Property for minimum Price
        /// </summary>
        [BindProperty]
        public float? minPrice { get; set; }

        /// <summary>
        /// Binding Property for maximum Price
        /// </summary>
        [BindProperty] 
        public float? maxPrice { get; set; }

        /// <summary>
        /// Binding Property for a List of string ingredients
        /// </summary>
        [BindProperty]
        public List<string> ingredient { get; set; } = new List<string>();

        public List<Size> Sizes { get; } = new List<Size> { Size.Small, Size.Medium, Size.Large };

        /// <summary>
        /// Method to call to website
        /// </summary>
        public void OnGet()
        {
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;
        }

        /// <summary>
        /// Method for each attribute set to post
        /// </summary>
        public void OnPost()
        {
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;

            if (search != null)
            {
                //SearchName(search);
                AvailableCombos = AvailableCombos.Where(item => item.Description.Contains(search, 
                    StringComparison.OrdinalIgnoreCase));

                AvailableEntrees = AvailableEntrees.Where(item => item.Description.Contains(search,
                    StringComparison.OrdinalIgnoreCase));

                AvailableSides = AvailableSides.Where(item => item.Description.Contains(search,
                    StringComparison.OrdinalIgnoreCase));

                AvailableDrinks = AvailableDrinks.Where(item => item.Description.Contains(search,
                    StringComparison.OrdinalIgnoreCase));
            }
            // MIN PRICE
            if (minPrice != null)
            {
                if (minPrice is float minimumPrice)
                {
                    AvailableCombos = AvailableCombos.Where(item => item.Price >= minimumPrice);
                    AvailableEntrees = AvailableEntrees.Where(item => item.Price >= minimumPrice);
                    AvailableSides = AvailableSides.Where(item => item.Price >= minimumPrice);
                    AvailableDrinks = AvailableDrinks.Where(item => item.Price >= minimumPrice);
                }
            }
            // MAX PRICE
            if (maxPrice != null)
            {
                if (maxPrice is float maximumPrice)
                {
                    AvailableEntrees = AvailableEntrees.Where(item => item.Price <= maximumPrice);
                    AvailableCombos = AvailableCombos.Where(item => item.Price <= maximumPrice);
                    AvailableEntrees = AvailableEntrees.Where(item => item.Price <= maximumPrice);
                    AvailableDrinks = AvailableDrinks.Where(item => item.Price <= maximumPrice);
                }
            }

            if (menuCategory.Count != 0)
            {
                if (!menuCategory.Contains("Combo"))
                {
                    AvailableCombos = new List<CretaceousCombo>();
                }
                if (!menuCategory.Contains("Entree"))
                {
                    AvailableEntrees = new List<Entree>();
                }
                if (!menuCategory.Contains("Side"))
                {
                    AvailableSides = new List<Side>();
                }
                if (!menuCategory.Contains("Drink"))
                {
                    AvailableDrinks = new List<Drink>();
                }
            }
            

            //INGREDIENT
            if (ingredient.Count > 0)
            {
                AvailableCombos = AvailableCombos.Where(item =>
                {
                    foreach (string i in ingredient)
                    {
                        if (item.Ingredients.Contains(i))
                        {
                            return false;
                        }
                    }
                    return true;
                });

                AvailableEntrees = AvailableEntrees.Where(item =>
                {
                    foreach (string i in ingredient)
                    {
                        if (item.Ingredients.Contains(i))
                        {
                            return false;
                        }
                    }
                    return true;
                });

                AvailableSides = AvailableSides.Where(item =>
                {
                    foreach (string i in ingredient)
                    {
                        if (item.Ingredients.Contains(i))
                        {
                            return false;
                        }
                    }
                    return true;
                });

                AvailableDrinks = AvailableDrinks.Where(item =>
                {
                    foreach (string i in ingredient)
                    {
                        if (item.Ingredients.Contains(i))
                        {
                            return false;
                        }
                    }
                    return true;
                });
            }
        } // End of OnPost method

        

            /// <summary>
            /// Search method to operate Search button for each item
            /// </summary>
            /// <param name="search"></param>
            private void SearchName(string search)
            {
                List<Entree> tempEntree = new List<Entree>();
                foreach (Entree entree in AvailableEntrees)
                {
                    if (entree.ToString() != null && entree.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        tempEntree.Add(entree);
                    }
                }
                AvailableEntrees = tempEntree;

                List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
                foreach (CretaceousCombo combo in AvailableCombos)
                {
                    if (combo.ToString() != null && combo.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        tempCombo.Add(combo);
                    }
                }
                AvailableCombos = tempCombo;

                List<Side> tempSide = new List<Side>();
                foreach (Side side in AvailableSides)
                {
                    if (side.ToString() != null && side.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        tempSide.Add(side);
                    }
                }
                AvailableSides = tempSide;

                List<Drink> tempDrink = new List<Drink>();
                foreach (Drink drink in AvailableDrinks)
                {
                    if (drink.ToString() != null && drink.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        tempDrink.Add(drink);
                    }
                }
                AvailableDrinks = tempDrink;
            } // end of searchName method


        /// <summary>
        /// maximum price filter value, only the menu items with a price 
        /// of less than or equal to the maximum are displayed
        /// </summary>
        /// <param name="maxPrice"></param>
        public static List<T> FilterByMaxPrice<T>(float maxPrice, List<T> menuItems) where T : IMenuItem
        {
            List<T> results = new List<T>();
            foreach(T item in menuItems)
            {
                if(item.Price <= maxPrice)
                {
                    results.Add(item);
                }
            }
            return results;
        } // end of FilterByMaxPrice method


        /// <summary>
        /// the form is submitted with a minimum value, only the menu items 
        /// with a price of more than or equal to the minimum are displayed.
        /// </summary>
        /// <param name="minPrice"></param>
        public static List<T> FilterByMinPrice<T>(List<T> menuItems, float minPrice) where T : IMenuItem
        {
            List<T> results = new List<T>();
            foreach (T item in menuItems)
            {
                if (item.Price >= minPrice)
                {
                    results.Add(item);
                }
            }
            return results;
        }


        /// <summary>
        /// Filters by ingredient associated to each menu item searched
        /// </summary>
        /// <param name="ingredient"></param>
        public static List<T> FilterByIngredient<T>(List<T> menuItems, List<string> ingredient)
            where T : IMenuItem
        {
            List<T> results = new List<T>();
            foreach(T item in menuItems)
            {
                bool filter = true;
                foreach(string i in ingredient)
                {
                    if (item.Ingredients.Contains(i))
                    {
                        filter = false;
                        break;
                    }
                }
                if (filter)
                {
                    results.Add(item);
                }
            }
            return results;
        } // End of FilterByIngredient method



    }
 } // End of Menu.cshtml.cs class
