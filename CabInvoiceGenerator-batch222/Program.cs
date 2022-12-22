using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator_batch222
{
    public class Program
    {
        static void Main()
        {
            Ride ride = new Ride(4, 2, RideType.NORMAL);
            CabInvoiceGenerator invoiceGenerator = new CabInvoiceGenerator();
            double actual = invoiceGenerator.CalculateTotalFare(ride);
            Console.WriteLine(actual);
          
        }
    }
}
