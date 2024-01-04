namespace Tourism.Bookings;

public abstract class Booking
{
    public DateTime StartTime { get; }
    public DateTime FinishTime { get; }
    public float Price { get; }

    protected Booking(DateTime startTime, DateTime finishTime, float price)
    {
        StartTime = startTime;
        FinishTime = finishTime;
        Price = price;
    }
}