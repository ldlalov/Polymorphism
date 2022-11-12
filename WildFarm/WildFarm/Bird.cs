using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }
        public double WingSize { get; set; }
    }
}
