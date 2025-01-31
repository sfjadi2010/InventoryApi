namespace InventoryApi.Models;

public class Inventory
{
    public int Id { get; set; }
    public string ProductCode { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int Quantity { get; set; }
}
