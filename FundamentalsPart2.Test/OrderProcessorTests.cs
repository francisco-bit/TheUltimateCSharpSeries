using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPart2;

namespace FundamentalsPart2.Test
{
    [TestClass]
    public class OrderProcessorTests
    {
        //When renaiming it should be like 
        //MethodName_Condition_Expectation
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            var orderProcess = new OrderProcessor(new FakeShippingCalculator());

        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
