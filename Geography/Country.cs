namespace Tourism.Geography;

public class Country
{
    public string Name { get; }
    public string Code { get; }
    public List<City> Cities {get;}
    
    public Country(string name, string code)
    {
        Name = name;
        Code = code;
        Cities = new List<City>();
    }

    public City AddCity(string name)
    {
        City city = new City(this, name);
        Cities.Add(city);
        return city;
    }
}