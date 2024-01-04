namespace Tourism.Accomodations;

public abstract class Accomodation
{
    protected Accomodation(string address, string description, string phone, string email)
    {
        Address = address;
        Description = description;
        Phone = phone;
        Email = email;
        Rating = 0f;
    }
    
    public string Address { get; set; }

    public string Description { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public float Rating { get; set; }
}