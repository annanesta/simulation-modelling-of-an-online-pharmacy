using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4SOSAPR
{
    public sealed class Item
    {
        private int number;
        private int amount;
        private decimal price;

        private static readonly Lazy<Item> instanceHolder =
            new Lazy<Item>(() => new Item());

        public int Number
        { set { number = value; } get { return number; } }
        public int Amount
        { set { amount = value; } get { return amount; } }
        public decimal Price
        { set { price = value; } get { return price; } }
    }
}
