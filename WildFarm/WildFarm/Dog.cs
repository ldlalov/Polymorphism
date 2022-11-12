using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        private List<string> foods = new List<string>() { "Meat" };
        public Dog(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }
        public override string ToString()
        {
            return $"{GetType().Name} {Name}, {Weight}, {LivingRegion}, {FoodEaten}";
        }

        public override string ProduceSount()
        {
            return $"Woof!";
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
