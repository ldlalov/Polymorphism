using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        private List<string> foods = new List<string>() { "Meat" };
        public Hen(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }
        public override string ToString()
        {
            return $"{GetType().Name} {Name}, {WingSize}, {Weight}, {FoodEaten}";
        }

        public override string ProduceSount()
        {
            return $"Cluck";
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
