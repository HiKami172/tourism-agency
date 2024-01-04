using Tourism.Users;

namespace Tourism.Accomodations;

public class Apartment : Accomodation
{
    private Owner _owner;
    
    public Apartment(Owner owner, string address, string description, string phone, string email) : base(address, description, phone, email)
    {
        Owner = owner;
    }

    public Owner Owner
    {
        get => _owner;
        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Owner cannot be null");
            }
            _owner = value;
        }
    }
}