using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class DinoNuggets
    {
        //private bool addNug = false;
        private uint chickenNug = 6;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Chicken Nuggets", "Chicken Nuggets", "Chicken Nuggets", "Chicken Nuggets", "Chicken Nuggets", "Chicken Nuggets"};
                //if (chickenNug) ingredients.Add("Chicken Nuggets");
                
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
        }

        //Implement method for adding a nugget at additional 0.25
        public void AddNugget()
        {
            chickenNug + 1;
            this.Price = 4.25 + 0.25;
            
              //  this.Price = chickenNug + 0.25;
            
            
        }


    }
}
