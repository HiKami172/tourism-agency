namespace Tourism.Users;

public class Admin : User
{
    public Admin(string login, string password, string email, string address, string phone) : base(login, password, email, address, phone)
    {
    }
}