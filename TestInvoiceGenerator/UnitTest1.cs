using NUnit.Framework;
using InvoiceGenerator;

namespace TestInvoiceGenerator
{
    public class Tests
    {
        CabInvoiceGenerator cabInvoiceGenerator = null;

        /// <summary>
        /// Test case for Checking Calculate fare Function
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            cabInvoiceGenerator = new CabInvoiceGenerator(RydeType.NORMAL);
            double distance = 2.0;
            int time = 5;

            double fare = cabInvoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }
    }
}