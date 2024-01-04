namespace Tourism.Accomodations;
public class Hotel : Accomodation
{
    public Hotel(string address, string description, string phone, string email, int stars) : base(address, description, phone, email)
    {
        Stars = stars;
    }
    public int Stars { get; set; }
}