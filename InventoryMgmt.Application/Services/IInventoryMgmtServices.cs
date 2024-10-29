using InventoryMgmt.Domain.Entities;

namespace InventoryMgmt.Application.Services;

public interface IInventoryMgmtServices
{
    Task<List<Inventory>> GetAllInventories();
    Task<Inventory> GetInventoryById(int Id);
    Task<Inventory> CreateInventory(Inventory inventory);
    Task<int> UpdateInventory(int Id, Inventory inventory);
    Task<int> DeleteInventory(int Id);
}
