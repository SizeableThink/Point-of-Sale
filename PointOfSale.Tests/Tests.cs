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
    }
}
