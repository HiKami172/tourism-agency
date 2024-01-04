using Tourism.Cabs;
using Tourism.Geography;

namespace Tourism.Bookings;

public class CabBooking : Booking
{
    public City Source { get; }
    public City Destination { get; }
    public Cab BookedCab { get; }

    public CabBooking(DateTime startTime, DateTime finishTime, float price, 
        City source, City destination, Cab cab) 
        : base(startTime, finishTime, price)
    {
        Source = source;
        Destination = destination;
        BookedCab = cab;
    }
}