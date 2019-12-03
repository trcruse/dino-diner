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
        public Menu Menu { get; private set; } = null;

        //public List<IMenuItem> AvailableMenuItem;

        //***********************
        public List<CretaceousCombo> AvailableCombos { get; private set; } = null;

        public List<Entree> AvailableEntrees { get; private set; } = null;

        public List<Side> AvailableSides { get; private set; } = null;

        public List<Drink> AvailableDrinks { get; private set; } = null;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; }

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty] 
        public float? maxPrice { get; set; }

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();



        public void OnGet()
        {
            if(Menu == null)
            {
                Menu = new Menu();
            }
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;
           
        }

        public void OnPost()
        {
            if (Menu == null)
            {
                Menu = new Menu();
            }
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;

            if (search != null)
            {
                AvailableCombos = Menu.Search(AvailableCombos, search);
                AvailableEntrees = Menu.Search(AvailableEntrees, search);
                AvailableSides = Menu.Search(AvailableSides, search);
                AvailableDrinks = Menu.Search(AvailableDrinks, search);
            }
            if (menuCategory.Count > 0 )
            {
                if(!menuCategory.Contains("Combos"))
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


            if(minPrice is float min)
            {
                AvailableCombos = Menu.FilterByMinPrice(AvailableCombos, min);
                AvailableEntrees = Menu.FilterByMinPrice(AvailableEntrees, min);
                AvailableSides = Menu.FilterByMinPrice(AvailableSides, min);
                AvailableDrinks = Menu.FilterByMinPrice(AvailableDrinks, min);
            }

            if (maxPrice is float max)
            {
                AvailableCombos = Menu.FilterByMaxPrice(AvailableCombos, max);
                AvailableEntrees = Menu.FilterByMaxPrice(AvailableEntrees, max);
                AvailableSides = Menu.FilterByMaxPrice(AvailableSides, max);
                AvailableDrinks = Menu.FilterByMaxPrice(AvailableDrinks, max);
            }

            if (excludedIngredients.Count > 0)
            {
                AvailableCombos = Menu.FilterByExcludedIngriedents(AvailableCombos, excludedIngredients);
                AvailableEntrees = Menu.FilterByExcludedIngriedents(AvailableEntrees, excludedIngredients);
                AvailableSides = Menu.FilterByExcludedIngriedents(AvailableSides, excludedIngredients);
                AvailableDrinks = Menu.FilterByExcludedIngriedents(AvailableDrinks, excludedIngredients);
            }







        }



    }
}