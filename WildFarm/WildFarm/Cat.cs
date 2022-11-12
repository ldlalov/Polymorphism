using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        private List<string> foods = new List<string>() { "Vegetable", "Meat" };

        public Cat(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }
        public override string ToString()
        {
            return $"{GetType().Name} {Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}";
        }

        public override string ProduceSount()
        {
            return $"Meow";
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
