using Tourism.Accomodations;

namespace Tourism.Bookings;


public enum RoomType
{
   Single,
   Double,
   Lux,
   None
}

public class AccomodationBooking: Booking
{
   private readonly Accomodation _bookedAccomodation;
   
   private readonly RoomType _roomType;
   
   public Accomodation BookedAccomodation
   {
      get { return _bookedAccomodation; }
   }
   
   public RoomType RoomType
   {
      get { return _roomType; }
   }
   
   public AccomodationBooking(
       DateTime startTime, 
       DateTime finishTime, 
       float price,
       Accomodation bookedAccomodation,
       RoomType roomType) : base(startTime, finishTime, price)
   {
      _bookedAccomodation = bookedAccomodation;
      _roomType = roomType;
   }
}