using CabInvoiceGenerator_batch222;

namespace CabInvoiceTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Step 1  (Calculate Fare -Normal Ride)
        public void Given_Distance_And_Time_Should_Return_TotalFare()
        {
            //4*10+2*1=42
            Ride ride = new Ride(4, 2, RideType.NORMAL);
            CabInvoiceGenerator invoiceGenerator = new CabInvoiceGenerator();
            double actual = invoiceGenerator.CalculateTotalFare(ride);
            double expected = 42;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(-5, 2, RideType.NORMAL)]   //Wrong input shall throw custome exception .
        public void Given_WrongDistance_And_Time_Should_Throw_CustomException()
        {
            Ride ride = new Ride(-5, 2, RideType.NORMAL);
            CabInvoiceGenerator invoiceGenerator = new CabInvoiceGenerator();
            var actual = Assert.ThrowsException<CabInvoiceCustomException>(() => invoiceGenerator.CalculateTotalFare(ride));
            Assert.AreEqual(actual.Message, "Invalid distance");
        }

        [TestMethod]
        public void Given_MultipleRides_Should_Return_Object()
        {
            Ride[] rides = new Ride[]
            {
                new Ride(1,2,RideType.NORMAL),  //10+2=12    +
                new Ride(2,1,RideType.PREMIUM)  //30+2=32       //44
            };
            InvoiceSummary expectedObj = new InvoiceSummary(44, rides.Length);
            CabInvoiceGenerator invoiceGenerator = new CabInvoiceGenerator();
            InvoiceSummary actual = invoiceGenerator.CalculateTotalFare(rides);
            Assert.AreEqual(expectedObj, actual);

        }
    }

}