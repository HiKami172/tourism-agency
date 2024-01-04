using System.Collections.Generic;
using Tourism.Bookings;
using Tourism.Users;

namespace Tourism;

public class Tour
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float Rating { get; set; }
    public Customer Customer { get; set; }
    public List<AccomodationBooking> AccommodationBookings { get; set; } = new List<AccomodationBooking>();
    public List<CabBooking> CabBookings { get; set; } = new List<CabBooking>();

    public Tour(string name, string description, float rating, Customer customer, List<AccomodationBooking> accommodationBookings, List<CabBooking> cabBookings)
    {
        Name = name;
        Description = description;
        Rating = rating;
        Customer = customer;
        AccommodationBookings = accommodationBookings;
        CabBookings = cabBookings;
    }

    public Tour(Customer customer, string name, string description, float rating)
    {
        Name = name;
        Description = description;
        Rating = rating;
        Customer = customer;
    }

    public void AddCabBooking(CabBooking cabBooking)
    {
        CabBookings.Add(cabBooking);
    }

    public void AddAccommodationBooking(AccomodationBooking accommodationBooking)
    {
        AccommodationBookings.Add(accommodationBooking);
    }

    public float CalculatePrice()
    {
        return CalculateBookingPrice(AccommodationBookings) + CalculateBookingPrice(CabBookings);
    }

    private float CalculateBookingPrice(IEnumerable<Booking> bookings)
    {
        float total = 0;
        foreach (var booking in bookings)
        {
            total += booking.Price;
        }

        return total;
    }
}