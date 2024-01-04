using Tourism.Users;

namespace Tourism;


public enum PaymentMethod
{
    DebitCard,
    BankTransfer,
    GooglePay,
    Cash,
    None
}

public class CheckoutReport
{
    public Tour Tour { get; }
    public Customer Customer { get; }
    public PaymentMethod PaymentMethod { get; }
    public DateTime PaymentDate { get; }
    
    public float Price
    {
        get => this.Tour.CalculatePrice();
    }

    public CheckoutReport(Tour tour, Customer customer, PaymentMethod paymentMethod)
    {
        Tour = tour;
        Customer = customer;
        PaymentMethod = paymentMethod;
        PaymentDate = DateTime.Now;
    }    
}