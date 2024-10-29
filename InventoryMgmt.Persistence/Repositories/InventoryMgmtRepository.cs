using InventoryMgmt.Domain.Entities;
using InventoryMgmt.Domain.Interfaces;
using InventoryMgmt.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryMgmt.Persistence.Repositories;

public class InventoryMgmtRepository(InventoryMgmtDbContext inventoryMgmtDbContext) : IInventoryMgmtRepository
{
    private readonly InventoryMgmtDbContext 
        _inventoryMgmtDbContext = inventoryMgmtDbContext;

    public async Task<Inventory> CreateAsync(Inventory inventory)
    {
        var result = _inventoryMgmtDbContext.Inventories.Add(inventory);
        await _inventoryMgmtDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<int> DeleteAsync(int id) => await _inventoryMgmtDbContext.Inventories.Where(i => i.Id == id).ExecuteDeleteAsync();

    public async Task<List<Inventory>> GetAllAsync() => await _inventoryMgmtDbContext.Inventories.ToListAsync();

    public async Task<Inventory> GetByIdAsync(int id) => await _inventoryMgmtDbContext.Inventories.Where(i => i.Id == id).FirstOrDefaultAsync();

    public async Task<int> UpdateAsync(int id, Inventory inventory) 
        => await _inventoryMgmtDbContext.Inventories.Where(i => i.Id == id)
            .ExecuteUpdateAsync(b => b
            .SetProperty(b => b.Name, inventory.Name)
            .SetProperty(b => b.Description, inventory.Description)
            );
}
