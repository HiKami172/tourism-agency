namespace Tourism.Users;


public abstract class User
{
    protected string _login;
    protected string _password;
    protected string _email;

    protected string _address;
    protected string _phone;


    protected User(string login, string password, string email, string address, string phone)
    {
        _login = login;
        _password = password;
        _email = email;
        _address = address;
        _phone = phone;
    }

    public string Login
    {
        get { return _login; }
    }

    public string Password
    {
        get { return _password; }
    }

    public string Email
    {
        get { return _email; }
    }

    public string Address
    {
        get { return _address; }
    }

    public string Phone
    {
        get { return _phone; }
    }
}