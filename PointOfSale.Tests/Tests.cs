using System;
using System.IO;
using System.Linq;
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
        public void CartIsNotNull()
        {
            ShoppingCart cart = new ShoppingCart();
            Assert.IsNotNull(cart, "Shopping cart is empty!");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CartIsOver50()
        {
            ShoppingCart cart = new ShoppingCart();
            //add 51 ProductIds to cart
            cart.ProductIDs = new string[] {"A", "A", "A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A",
                "A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A","A",
                "A","A","A","A"};
            cart.CheckCartSize();
        }
    }
}
