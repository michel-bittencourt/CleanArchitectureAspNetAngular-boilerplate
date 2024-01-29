namespace Domain.Entities;

public sealed class Supplier : EntityID
{
    public string Name { get; private set; }
    public string TaxID { get; private set; }
    public string Address { get; private set; }
    public string Contact { get; private set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();

    public Supplier(string name, string taxID, string address, string contact)
    {
        Name = name;
        TaxID = taxID;
        Address = address;
        Contact = contact;
    }
}
