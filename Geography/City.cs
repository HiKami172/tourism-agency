namespace Tourism.Geography;

public class City
{
    public string Name { get; }
    public Country LocationCountry { get; }
    
    public City(Country country, string name)
    {
        LocationCountry = country;
        Name = name;
    }
}