using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }
        public string Breed { get; set; }
    }
}
