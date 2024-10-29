using InventoryMgmt.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryMgmt.Persistence.Data;

public class InventoryMgmtDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Inventory> Inventories { get; set; }
}
