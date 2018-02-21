using System;
namespace PointOfSale
{
    public class ShoppingCart
    {
        private string[] ProductIDs;
        private Customer customer;

        /*public decimal calcPurchasePrice(ProductIds[] list, Customer customer)
        {
            return 0;
        }*/

        //public ShoppingCart() => ProductIDs = [A, B, C, D];
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
