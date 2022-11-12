using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Vegetable : Food
    {
        public Vegetable(string name, int quantity) : base(name, quantity)
        {
        }
        public override string ToString()
        {
            return $"{GetType().Name} {Quantity}";
        }
    }
}
