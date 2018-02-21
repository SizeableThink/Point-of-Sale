using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PointOfSale
{
    public class Database
    {
        public Dictionary<string, Item> items = new Dictionary<string, Item>() {
            { "A", new Item("A", 1.00) },
            { "B", new Item("B", 2.00) },
            { "C", new Item("C", 3.00) },
            { "D", new Item("D", 4.00) },
            { "E", new Item("E", 5.00) },
        };

        public Item GetItem(string id)
        {
            return items[id];
        }
    }
}
