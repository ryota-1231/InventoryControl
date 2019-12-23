using Microsoft.EntityFrameworkCore;
using InventoryControl.Models;

namespace InventoryControl.Data
{
    public class InventoryControlContext : DbContext
    {
        public InventoryControlContext(DbContextOptions<InventoryControlContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}