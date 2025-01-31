using InventoryApi.Models;
using InventoryApi.Services.Interfaces;

namespace InventoryApi.Services;

public class InventoryService : IInventoryService
{
    Dictionary<string, Inventory> _inventories = new();

    public IEnumerable<Inventory> GetAll()
    {
        return _inventories.Values;
    }

    public Inventory GetByProductCode(string productCode)
    {
        return _inventories[productCode];
    }

    public void Add(Inventory inventory)
    {
        if (!_inventories.ContainsKey(inventory.ProductCode))
        {
            _inventories[inventory.ProductCode] = inventory;
        }
        else
        {
            _inventories[inventory.ProductCode].Quantity += inventory.Quantity;
        }
    }

    public void Update(Inventory inventory)
    {
    }

    public void RemoveOne(string productCode)
    {
        if (_inventories.TryGetValue(productCode, out Inventory? item))
        {
            _inventories.Remove(item.ProductCode);
        }
    }
}
