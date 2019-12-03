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






        }



    }
}