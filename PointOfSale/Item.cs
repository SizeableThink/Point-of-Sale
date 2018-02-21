using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PointOfSale
{
    public class Item
    {
        private string ProductID;
        private double Price;

        public Item(string id, double price)
        {
            ProductID = id;
            Price = price;
        }

        public double GetPrice()
        {
            return this.Price;
        }
    }
}
