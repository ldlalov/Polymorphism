using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Food
    {
        public Food(string name,int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} {Quantity}";
        }
    }
}
