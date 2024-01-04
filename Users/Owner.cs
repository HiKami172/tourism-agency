using Tourism.Accomodations;

namespace Tourism.Users;

public class Owner : User
{
    private List<Apartment> _ownedApartments = new();

    public Owner(string login, string password, string email, string address, string phone) : base(login, password, email, address, phone)
    {
    }

    private Apartment RegisterApartment(string address, string description)
    {
        Apartment apartment = new Apartment(this, address, description, _phone, _email);
        _ownedApartments.Add(apartment);
        return apartment;
    }
}