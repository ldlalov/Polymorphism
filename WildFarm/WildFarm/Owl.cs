using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private List<string> foods = new List<string>() {"Meat"};
        public Owl(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }


        public override string ToString()
        {
            return $"{GetType().Name} {Name}, {WingSize}, {Weight}, {FoodEaten}";
        }
        public override string ProduceSount()
        {
            return $"Hoot Hoot";
        }

        public override void Eat(string food)
        {
            if (!foods.Contains(food))
            {
                throw new ArgumentException($"{GetType().Name}  does not eat {food}!");
            }
        }
    }
}
