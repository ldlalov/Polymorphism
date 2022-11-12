﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Fruit : Food
    {
        public Fruit(string name, int quantity) : base(name, quantity)
        {
        }
        public override string ToString()
        {
            return $"{GetType().Name} {Quantity}";
        }

    }
}
