using NUnit.Framework;
using OTS_Supermarket.Models;


namespace OTS_Supermarket.Test
{
    [TestFixture]
    public class CartTest
    {
        [Test]
        public void AddOneToCart_ShouldAddOneToCart_Success()
        {
            // ARRANGE
            Cart cart = new Cart();
            Monitor monitor = new Monitor();
            
            // ACT
            cart.AddOneToCart(monitor);

            // ASSERT
            Assert.That(cart.Size, Is.EqualTo(2));
            Assert.That(cart.Amount, Is.EqualTo(100));

        }




    }
}
