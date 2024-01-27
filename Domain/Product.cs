namespace Domain;

public sealed class Product : EntityID
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string PurchasePrice { get; private set; }
    public string SellingPrice { get; private set; }
    public string StokeQuantity { get; private set; }
}
