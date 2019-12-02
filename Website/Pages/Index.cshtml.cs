using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Menu> Menu;
        public string search { get; set; }

        

        public void OnGet()
        {

        }
    }
}
