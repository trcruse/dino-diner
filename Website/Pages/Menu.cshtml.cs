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
        public List<CretaceousCombo> AvailableCombos { get; set; } 

        /// <summary>
        /// List of Available Entrees
        /// </summary>
        public List<Entree> AvailableEntrees { get; set; } 

        /// <summary>
        /// List of Available Sides
        /// </summary>
        public List<Side> AvailableSides { get; set; }

        /// <summary>
        /// List of Available drinks
        /// </summary>
        public List<Drink> AvailableDrinks { get; set; }

        /// <summary>
        /// Binding Property for search
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
        /// <param name="search"></param>
        /// <param name="menuCategory"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="ingredient"></param>
        public void OnPost()
        {
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;

            if (search != null)
            {
                SearchName(search);
            }
            if(minPrice != null)
            {
                FilterByMinPrice(minPrice);
            }
            if(maxPrice != null)
            {
                FilterByMaximumPrice(maxPrice);
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
        } // End of OnPost method

        /// <summary>
        /// Filters each menu item by their category
        /// </summary>
        /// <param name="menuCategory"></param>
        private void FilterByCategory(List<string> menuCategory)
        {
            if (!menuCategory.Contains("Combo"))
            {
                AvailableCombos = new List<CretaceousCombo>();
            }
            if(!menuCategory.Contains("Entree"))
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
        /// the form is submitted with a minimum value, only the menu items 
        /// with a price of more than or equal to the minimum are displayed.
        /// </summary>
        /// <param name="minPrice"></param>
        private void FilterByMinPrice(float? minPrice)
        {
            List<Entree> tempEntree = new List<Entree>();
            foreach(Entree entree in AvailableEntrees)
            {
                if (entree.Price >= minPrice)
                {
                    tempEntree.Add(entree);
                }
            }
            AvailableEntrees = tempEntree;

            List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
            foreach (CretaceousCombo combo in AvailableCombos)
            {
                if (combo.Price >= minPrice)
                {
                    tempCombo.Add(combo);
                }
            }
            AvailableCombos = tempCombo;

            List<Side> tempSide = new List<Side>();
            foreach (Side side in AvailableSides)
            {
                if (side.Price >= minPrice)
                {
                    tempSide.Add(side);
                }
            }
            AvailableSides = tempSide;

            List<Drink> tempDrink = new List<Drink>();
            foreach (Drink drink in AvailableDrinks)
            {
                if (drink.Price >= minPrice)
                {
                    tempDrink.Add(drink);
                }
            }
            AvailableDrinks = tempDrink;

        } // end of FilterByMinPrice method


        /// <summary>
        /// maximum price filter value, only the menu items with a price 
        /// of less than or equal to the maximum are displayed
        /// </summary>
        /// <param name="maxPrice"></param>
        private void FilterByMaximumPrice(float? maxPrice)
        {
            List<Entree> tempEntree = new List<Entree>();
            foreach (Entree entree in AvailableEntrees)
            {
                if (entree.Price <= maxPrice)
                {
                    tempEntree.Add(entree);
                }
            }
            AvailableEntrees = tempEntree;

            List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
            foreach (CretaceousCombo combo in AvailableCombos)
            {
                if (combo.Price <= maxPrice)
                {
                    tempCombo.Add(combo);
                }
            }
            AvailableCombos = tempCombo;

            List<Side> tempSide = new List<Side>();
            foreach (Side side in AvailableSides)
            {
                if (side.Price <= maxPrice)
                {
                    tempSide.Add(side);
                }
            }
            AvailableSides = tempSide;

            List<Drink> tempDrink = new List<Drink>();
            foreach (Drink drink in AvailableDrinks)
            {
                if (drink.Price <= maxPrice)
                {
                    tempDrink.Add(drink);
                }
            }
            AvailableDrinks = tempDrink;
        } // end of FilterByMaxPrice method


        /// <summary>
        /// Filters by ingredient associated to each menu item searched
        /// </summary>
        /// <param name="ingredient"></param>
        private void FilterByIngredient(List<string> ingredient)
        {
            List<Entree> tempEntree = new List<Entree>();
            List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
            List<Side> tempSide = new List<Side>();
            List<Drink> tempDrink = new List<Drink>();

            foreach(string item in ingredient)
            {
                foreach(Entree entree in AvailableEntrees)
                {
                    if (entree.Ingredients != null && entree.Ingredients.Contains(item))
                    {
                        tempEntree.Add(entree);
                    }
                }
                foreach (CretaceousCombo combo in AvailableCombos)
                {
                    if (combo.ToString() != null && combo.Ingredients.Contains(item))
                    {
                        tempCombo.Add(combo);
                    }
                }
                foreach (Side side in AvailableSides)
                {
                    if (side.ToString() != null && side.Ingredients.Contains(item))
                    {
                        tempSide.Add(side);
                    }
                }
                foreach (Drink drink in AvailableDrinks)
                {
                    if (drink.ToString() != null && drink.Ingredients.Contains(item))
                    {
                        tempDrink.Add(drink);
                    }
                }

                foreach(Entree entree in tempEntree)
                {
                    AvailableEntrees.Remove(entree);
                }
                foreach(CretaceousCombo combo in tempCombo)
                {
                    AvailableCombos.Remove(combo);
                }
                foreach(Side side in tempSide)
                {
                    AvailableSides.Remove(side);
                }
                foreach(Drink drink in tempDrink)
                {
                    AvailableDrinks.Remove(drink);
                }
            }
        } // End of FilterByIngredient method



    }
 } // End of Menu.cshtml.cs class
