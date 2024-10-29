using InventoryMgmt.Domain.Entities;

namespace InventoryMgmt.Domain.Interfaces;

public interface IInventoryMgmtRepository
{
    Task<List<Inventory>> GetAllAsync();
    Task<Inventory> GetByIdAsync(int id);
    Task<Inventory> CreateAsync(Inventory inventory);
    Task<int> UpdateAsync(int id, Inventory inventory);
    Task<int> DeleteAsync(int id);
}
