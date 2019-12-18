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

        public DbSet<Client> Client { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
    }
}