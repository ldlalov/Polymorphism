using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private List<string> foods = new List<string>() { "Vegetable", "Fruit" };

        public Mouse(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }
        public override string ToString()
        {
            return $"{GetType().Name} {Name}, {Weight}, {LivingRegion}, {FoodEaten}";
        }

        public override string ProduceSount()
        {
            return $"Squeak";
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
