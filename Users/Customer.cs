namespace Tourism.Users;

public class Customer : User
{
    private List<Tour> _bookedTours = new();
    
    
    public Customer(string login, string password, string email, string address, string phone) : base(login, password, email, address, phone)
    {
    }


    public List<Tour> GetBookedTours()
    {
        return _bookedTours;
    }


    public void BookTour(Tour tour, PaymentMethod paymentMethod)
    {
        _bookedTours.Add(tour);
        CheckoutReport checkoutReport = new CheckoutReport(tour, this, paymentMethod);
    }
}