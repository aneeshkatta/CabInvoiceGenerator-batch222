using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator_batch222
{
    public class InvoiceSummary
    {
        public double totalFare;
        public double numberOfRides;
        public double average;
        public InvoiceSummary(double totalFare, double numberOfRides)
        {
            this.totalFare = totalFare;
            this.numberOfRides = numberOfRides;
            this.average = totalFare / numberOfRides;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) 
            {
                return false;
            }
            if (obj is not InvoiceSummary)
            {
                return false;
            }
            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputedObject.numberOfRides && this.totalFare == inputedObject.totalFare;
        }
    }
}
