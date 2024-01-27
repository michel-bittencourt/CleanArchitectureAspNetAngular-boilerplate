namespace Domain;

public sealed class Product : EntityID
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal PurchasePrice { get; private set; }
    public decimal SellingPrice { get; private set; }
    public int StokeQuantity { get; private set; }

    public Product(string name, string description, decimal purchasePrice, decimal sellingPrice, int stokeQuantity)
    {
        Name = name;
        Description = description;
        PurchasePrice = purchasePrice;
        SellingPrice = sellingPrice;
        StokeQuantity = stokeQuantity;
    }
}
