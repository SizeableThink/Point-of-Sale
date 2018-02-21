using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using PointOfSale;


namespace PointOfSale.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestsCanPass()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestCartIsNotNull()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            Assert.IsNotNull(cart, "Shopping cart is empty!");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCartIsOver50()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            //add 51 ProductIds to cart
            cart.ProductIDs = new string[] {"A", "A", "A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A",
                "A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A",
                "A","A","A","A"};
            cart.CheckCartSize();
        }

        [Test]
        public void TestCartIsAt50()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            //add 50 ProductIds to cart
            cart.ProductIDs = new string[] {"A", "A", "A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A",
                "A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A",
                "A","A","A"};
            Assert.IsTrue(cart.CheckCartSize());
        }

        [Test]
        public void TestCartTotal()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            cart.ProductIDs = new string[] {"A", "A"};
            Assert.AreEqual(cart.Total(),2);
        }

        [Test]
        public void TestVolumeDiscountOver10Items()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            //add 13 items to cart
            cart.ProductIDs = new string[] { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A" };
            Assert.AreEqual(cart.VolumeDiscount(), 1.30);
        }

        [Test]
        public void TestVolumeDiscount10Items()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            //add 10 items to cart
            cart.ProductIDs = new string[] { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A" };
            Assert.AreEqual(cart.VolumeDiscount(), 1);
        }

        [Test]
        public void TestVolumeDiscountGreaterThan5LessThan10Items()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            //add 9 items to cart
            cart.ProductIDs = new string[] { "A", "A", "A", "A", "A", "A", "A", "A", "A" };
            Assert.AreEqual(cart.VolumeDiscount(), .45);
        }

        [Test]
        public void TestVolumeDiscountGreaterThan5With5Items()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            //add 5 items to cart
            cart.ProductIDs = new string[] { "A", "A", "A", "A", "A" };
            Assert.AreEqual(cart.VolumeDiscount(), 0);
        }

        [Test]
        public void TestVolumeDiscountWith0Items()
        {
            ShoppingCart cart = new ShoppingCart(new Database());
            //add 0 items to cart
            cart.ProductIDs = new string[] {};
            Assert.AreEqual(cart.VolumeDiscount(), 0);
        }
    }
}
