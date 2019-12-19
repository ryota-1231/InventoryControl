using System;
using System.ComponentModel.DataAnnotations;
namespace InventoryControl.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
