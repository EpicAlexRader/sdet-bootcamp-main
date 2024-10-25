using Moq;
using NUnit.Framework;
//using SdetBootcampDay2.TestObjects.Answers;
using SdetBootcampDay2.TestObjects.Exercises;

namespace SdetBootcampDay2.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        [Test]
        public void MockPaymentProcessor_ReturnFalseForAllStripePayments()
        {
            Dictionary<OrderItem, int> stock = new Dictionary<OrderItem, int>
            {
                { OrderItem.FIFA_24, 10 }
            };
            //recipient.Verify(r => r.GetMessages(), Times.Once()); - need this
            //recipient.Setup(o => o.GetMessages()).Returns("MOCKED messages");
            /**
             * TODO: Create a mock object representing the payment processor. Pass in Stripe
             * as the payment processor type. Set up the mock so that a call to PayFor() with
             * FIFA 24 and 10 as arguments returns false.
             */
            
            var mockTest = new Mock<IPaymentProcessor>();//Make a mock object and subscribe to IPaymentProcessor
            mockTest.Setup(o => o.PayFor(OrderItem.FIFA_24, 10)).Returns(false); // This will yell if we dont use payfor since our interface only has a payfor


            /**
             * TODO: Complete the test by creating a new OrderHandler, passing in the mock object
             * for the payment processor. Call the Order() method and then assert that the PayFor()
             * method of the OrderHandler returns false
             */
            var orderHandle = new OrderHandler(stock, mockTest.Object);

            orderHandle.Order(OrderItem.FIFA_24, 10);

            Assert.That(orderHandle.Pay(OrderItem.FIFA_24, 10), Is.False);

            /**
             * TODO: verify that the PayFor() method of the mock payment processor was called
             * exactly once with FIFA_24 and 10 as parameters.
             */
            mockTest.Verify(r => r.PayFor(OrderItem.FIFA_24, 10), Times.Once());
        }
    }
}
