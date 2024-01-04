namespace Tourism.Cabs;

public enum CabType
{
    Aero,
    Railway,
    Bus,
    Self,
}

public class Cab
{
    public string Name { get; set; }
    public string Description { get; set; }
    public CabType CabType { get; }

    public Cab(string name, string description, CabType cabType)
    {
        Name = name;
        Description = description;
        CabType = cabType;
    }
}