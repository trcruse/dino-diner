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

        public string Search { get; set; }

        public string Entree { get; set; }

        public string Combo { get; set; }

        public string Side { get; set; }

        public string Drink { get; set; }


        /// <summary>
        /// Instance calling Menu
        /// </summary>
        public Menu menu { get; } = new Menu();

        public List<IMenuItem> AvailableMenuItem;

        public void OnGet()
        {
           
        }





    }
}