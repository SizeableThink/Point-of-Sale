using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace PointOfSale
{
    public class ShoppingCart
    {
        public string[] ProductIDs;
        public Customer customer;
        private Database db;

        public ShoppingCart(Database database)
        {
            db = database;
        }

        public double Total()
        {
            double sum = 0;
            for (int i = 0; i < ProductIDs.Length; i++)
            {
                sum += db.GetItem(ProductIDs[i]).GetPrice();
            }
            return sum;
        }

        public bool CheckCartSize()
        {
            if (ProductIDs.Length > 50)

            {
                throw new InvalidOperationException("Cart size cannot be greater than 50");
            }

            else
            { 
                return true; 
            }
        }

        public double VolumeDiscount()
        {
            //calculate cart total

            if (ProductIDs.Length >= 10)
            {
                return Total() * .1;
            }

            else if (ProductIDs.Length > 5)
            {
                return Total() * .05;
            }
            return 0;
            /*
            Elseif(cart items  >= 5 and < 10)

        {
                Return total of cart contents - (total of cart contents * .05);
            }
            Else(cart items >= 10)

        {
                Return total of cart contents - (total of cart contents * .1);
            }
        }

        /*public decimal calcPurchasePrice(ProductIds[] list, Customer customer)
        {
            return 0;
        }*/
        }    

    }
        public class Customer
    {
        private string customerID;
        private bool memberStatus;
        private bool taxStatus;
    }

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
