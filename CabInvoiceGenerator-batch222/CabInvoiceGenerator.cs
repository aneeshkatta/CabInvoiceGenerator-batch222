using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator_batch222
{
    public  class CabInvoiceGenerator
    {
        public double CalculateTotalFare(Ride ride)
        {
            double totalFare;
            if (ride.distance <= 0)
            {
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_DISTANCE, "Invalid distance");
            }
            else if (ride.time <= 0)
            {
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_TIME,"Invalid time");
            }
            else
            {
                totalFare = ride.distance * ride.DISTANCE_PER_KM + ride.time * ride.COST_PER_MIN;
                return Math.Max(totalFare, ride.MINIMUM_FARE);
            }
        }
        public InvoiceSummary CalculateTotalFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach (Ride ride in rides)
            {
                totalFare += CalculateTotalFare(ride);
            }
            return new InvoiceSummary(totalFare, rides.Length);
        }
    }
}
