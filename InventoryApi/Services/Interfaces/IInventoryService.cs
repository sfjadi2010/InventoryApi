using InventoryApi.Models;

namespace InventoryApi.Services.Interfaces;

public interface IInventoryService
{
    public IEnumerable<Inventory> GetAll();
    public Inventory GetByProductCode(string productCode);
    public void Add(Inventory inventory);
    public void Update(Inventory inventory);
    public void RemoveOne(string productCode);
}
