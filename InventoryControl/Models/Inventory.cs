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
        public virtual Item Item{ get; set; }
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
