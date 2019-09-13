﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        //private bool addNug = false;
        private uint chickenNug = 6;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                //if (chickenNug) 
                for (int i = 0; i < chickenNug; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*chickenNug;
        }

        //Implement method for adding a nugget at additional 0.25
        public void AddNugget()
        {
            chickenNug = chickenNug + 1;
            this.Price = 4.25 + 0.25;
            
        }


    }
}
