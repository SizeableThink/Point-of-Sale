using System;
namespace PointOfSale
{
    public class ShoppingCart
    {
        public string[] ProductIDs;
        public Customer customer;

        public void CheckCartSize()
        {
            if (ProductIDs.Length > 50)

            {
                throw new InvalidOperationException("Cart size cannot be greater than 50");
            }
        }

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
