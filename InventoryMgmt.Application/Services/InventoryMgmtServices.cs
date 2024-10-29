using InventoryMgmt.Domain.Entities;
using InventoryMgmt.Domain.Interfaces;

namespace InventoryMgmt.Application.Services;

public class InventoryMgmtServices(IInventoryMgmtRepository inventoryMgmtRepository) : IInventoryMgmtServices
{
    private readonly IInventoryMgmtRepository _inventoryMgmtRepository = inventoryMgmtRepository;

    public async Task<Inventory> CreateInventory(Inventory inventory) => await _inventoryMgmtRepository.CreateAsync(inventory);

    public async Task<int> DeleteInventory(int Id) => await _inventoryMgmtRepository.DeleteAsync(Id);

    public async Task<List<Inventory>> GetAllInventories() => await _inventoryMgmtRepository.GetAllAsync();

    public async Task<Inventory> GetInventoryById(int Id) => await _inventoryMgmtRepository.GetByIdAsync(Id);

    public async Task<int> UpdateInventory(int Id, Inventory inventory) => await _inventoryMgmtRepository.UpdateAsync(Id, inventory);
}
