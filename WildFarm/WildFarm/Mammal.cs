using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }

        public string LivingRegion { get; set; }
    }
}
