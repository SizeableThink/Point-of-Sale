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
            if (ProductIDs.Length >= 10)
            {
                return Total() * .1;
            }

            else if (ProductIDs.Length > 5)
            {
                return Total() * .05;
            }

            else
            {
                return 0;
            }
        }

        public double MemberDiscount()
        {
            if (customer.GetMemberStatus() == true)
            {
                return Total() * .1;
            }

            else
            {
                return 0;
            }
        }

        public double ApplyTax(double subtotal)
        {
            if (customer.GetTaxStatus() == false)
            {
                return subtotal + (subtotal * .045);
            }

            else
            {
                return subtotal;
            }
        }

        public double CalcPurchasePrice()
        {
            CheckCartSize();
            double subtotal = Total();
            subtotal = subtotal - VolumeDiscount();
            subtotal = subtotal - MemberDiscount();
            subtotal = Math.Round(subtotal, 2);
            subtotal = ApplyTax(subtotal);
            subtotal = Math.Round(subtotal, 2);
            return subtotal;
        }

    }
        




}
