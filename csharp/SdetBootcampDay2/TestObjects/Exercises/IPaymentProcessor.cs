using System;
namespace SdetBootcampDay2.TestObjects.Exercises;

public interface IPaymentProcessor
{
    // private readonly PaymentProcessorType paymentProcessorType;
    bool PayFor(OrderItem item, int quantity);

    //string GetMessage(); //- this is a test to see how minimum requirments work
}