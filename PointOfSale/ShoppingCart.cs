using System;
namespace PointOfSale
{
    public class ShoppingCart
    {
            public string[] ProductIDs;
            public Customer customer;
    }

    public class Customer
    {
        private string memberStatus;
        private string taxStatus;
        private string customerID;
    }

    public class Item
    {
        public string name;
        public decimal price;
        public string ProductID;

        public decimal GetPrice(string ProductID)
        {
            return this.price;
        }
    }

    public class Database
    {
        public Item item;
    }
}
